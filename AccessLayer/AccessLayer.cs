using System.Collections.Generic;
using Portfolio.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;

namespace Portfolio.AccessLayer
{
    public abstract class AccessLayer<T, U> : IAccessLayer<U> where T: DbContext
    {
        public readonly T                     _context    ;
        public AccessLayer(
                            T               context
                          )
        {
            _context   = context; 
        }


        public abstract List<U>      List();
        public abstract U            Get();
        public abstract void         Remove();
        public abstract U            Add();
        public abstract bool         Validate(U entity);
        public abstract void         Update();
        public          void         Save(){
            _context.SaveChanges();
        }
    }
}