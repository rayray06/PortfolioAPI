using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Portfolio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Settings;
using Portfolio.Local;
using Portfolio.Exceptions;


/**
* NO NEED TO KNOW HOW IT IS WORK, JUST USE INTERFACE 
**/
namespace Portfolio.Data.AccessObjects
{
    public class DataAccessObject: IDataAccessObject
    {
        private readonly PortfolioContext  _myDbContext;

        private readonly List<object> _accessLayers;
        
        public DataAccessObject(
            PortfolioContext myDbContext,
            IServiceProvider services
        ) {
            _myDbContext     = myDbContext;
            _accessLayers    = new List<object>();
        }

        public T        Get<T>(params object[] args) where T : class
        {
            return AccessLayerInvoke<T>( args,
                                         STRING.Query.GET) 
                                         as T;
        }

        public List<T> List<T>(params object[] args) where T : class
        {
            return AccessLayerInvoke<T>( args, 
                                         STRING.Query.LIST) 
                                         as List<T>;
        }

        public T Add<T>(params object[] args) where T : class
        {
            return AccessLayerInvoke<T>(args,
                                         STRING.Query.ADD)
                                         as T;
        }
        public void Remove<T>(params object[] args) where T : class
        {
            var _ = AccessLayerInvoke<T>(args,
                                         STRING.Query.REMOVE)
                                         as List<T>;
        }

        
        public void Validate<T>(params object[] args) where T : class
        {
            var _ = AccessLayerInvoke<T>(args,
                                         STRING.Query.VALIDATE)
                                         as List<T>;
        }

        public void Save()
        {
            _myDbContext.SaveChanges();
            
        }

         public void Update<T>(params object[] args) where T : class
         {
            var _ =  AccessLayerInvoke<T>(args,
                                          STRING.Query.UPDATE)
                                          as T;
         }
         
        public DbContext GetContext<T>() where T: class
        {
            var lastNamespace = typeof(T)
                                .Namespace
                                .Split('.')
                                .Last();

            return GetContext(lastNamespace);
        }

        private object AccessLayerInvoke<T>(
            object[] args, 
            string   methodName
        ) {
            var lastNamespace = typeof(T)
                                    .Namespace
                                    .Split('.')
                                    .Last();

            
            var context = GetContext(lastNamespace);

            

            if (args is null) args = Array.Empty<object>();
            
            try 
            { 
                
                var  accessLayerNameSpace = $"Portfolio.AccessLayer";//$"RialPayAPI.Data.AccessLayers";
                var  entityAccessLayer    = typeof(T).Name;
                var  charIndex            = entityAccessLayer.IndexOf('`');


                if (charIndex > 0)
                    entityAccessLayer = entityAccessLayer.Substring(0, charIndex);




                entityAccessLayer = string.Concat(entityAccessLayer, "AccessLayer");

                Console.WriteLine($"{accessLayerNameSpace}.{entityAccessLayer}");
                Type accessLayerType = Type.GetType($"{accessLayerNameSpace}.{entityAccessLayer}");
                
                
                object accessLayer = _accessLayers
                                        .Where(x => x.GetType().Equals(accessLayerType))
                                        .FirstOrDefault();
                
                if (accessLayer is null)
                {

                    
                    
                    ConstructorInfo constructorInfo = accessLayerType.GetConstructor(new Type[] { context.GetType() });
                    



                    accessLayer = constructorInfo.Invoke( new object[]{ context } );
                    _accessLayers.Add(accessLayer);
                }
                
                
                return GetMethod( accessLayerType, 
                                  methodName, 
                                  args )
                        .Invoke(accessLayer, 
                                args);
            }
            catch(TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }

        private DbContext GetContext(
            string lastNamespace
        ) {
            Console.WriteLine(lastNamespace);
            return lastNamespace switch
            {
                "Portfolio" => _myDbContext,

                _ => throw new NotImplementedException("No context found from entity"),
            };
        }

        private static MethodInfo GetMethod(
            Type     fromClass, 
            string   methodName, 
            object[] parameters 
        ) {
            try
            {

                return fromClass.GetMethod( methodName, 
                                            BindingFlags.Public | BindingFlags.Instance, 
                                            null, 
                                            CallingConventions.Any, 
                                            Signature(parameters),
                                            null    );
            }
            catch(Exception e)
            {
                throw new PortfolioDAOException(string.Format("Method not found: {0}", e.Message), 
                                            ErrorCodes.AccessObject.DA_DAO_GM_method);
            }
        }

        private static Type[] Signature(
            object[] parameters
        ) {
            Type[] signature = new Type[parameters.Length];

            for(int i=0; i < parameters.Length; i++)
            {
                signature[i] = parameters[i].GetType();
            }
            return signature;
        }
    }
}