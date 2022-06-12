namespace Portfolio.Local
{
    public static class STRING
    {

        public static class Settings 
        {
            public const string APP_SECTION = "application";
            public const string PRODUCTION  = "appsettings.json";
            public const string DEVELOPMENT = "appsettings.Development.json";
        }

        public static class CONNECTION
        {
            public const string RialPay = "RialPay";            
        }

        public static class Query
        {
            public const string GET      = "Get"     ;
            public const string ADD      = "Add"     ;
            public const string UPDATE   = "Update"  ;    
            public const string LIST     = "List"    ;
            public const string REMOVE   = "Remove"  ;
            public const string VALIDATE = "Validate";
        }

        public class Exception
        {
            public const string AUTH_HEADER = "WWW-Authenticate";

            public class LOGIN
            {
                private const int LOGINCODE = 1;
                public class CLIENT
                {
                    private const int CLIENTBASE = LOGINCODE*10 + 1;
                    public const int WRONGCREDENTIAL = CLIENTBASE*10 + 1;

                }

                public class SERVER
                {
                    public const int SERVERBASE = LOGINCODE*10 + 2;     
                }

            }

            public class SIGNUP
            {
                private const int SIGNUPCODE = 2;
                public class CLIENT
                {
                    private const int CLIENTBASE = SIGNUPCODE*10 + 1;
                    public const  int MAILINUSE = CLIENTBASE*10 + 1;
                    public const  int PASSWORDINCORRECT = CLIENTBASE*10 + 2;
                    public const  int INCORRECTFORM = CLIENTBASE*10 + 3;

                }

                public class SERVER
                {
                    private const int SERVERBASE = SIGNUPCODE*10 + 2;

                    public  const int SIGNUPERROR = SERVERBASE*10 + 1;
                }

            }

            public class TOKEN
            {
                private const int TOKENCODE = 3;
                public class CLIENT
                {
                    private const int CLIENTBASE = TOKENCODE*10 + 1;
                    public const  int WRONGTOKEN = CLIENTBASE*10 + 1;
                    public const  int EXPIREDTOKEN = CLIENTBASE*10 + 2;

                }

                public class SERVER
                {
                    private const int SERVERBASE = TOKENCODE*10 + 2;

                }
            }
        }
    }
}