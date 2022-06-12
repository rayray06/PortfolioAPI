namespace Portfolio.Route
{
    public static class RialPayRoute
    {
        private const string BASE = "Portfolio/";

        public static class API 
        {
            private const string NAME      = "API";
            public const string FULL_NAME = BASE + NAME;

            public static class CLIENT { 
                private const string BASECLIENT = "CLIENT/";
                public const string LOGIN       = BASECLIENT+"Login";
                public const string SIGNUP      = BASECLIENT+"Signup";
                public const string ACTIVATE    = BASECLIENT+"Activate";
                public const string HOMEPAGE    = BASECLIENT+"Homepage";
            }

            public static class EXTERNAL
            {
                private const string BASEEXTERNAL = "EXTERNAL/";
                public  const string PHONECODE    = BASEEXTERNAL+"CountryInfo";
                public  const string COUNTRY    = BASEEXTERNAL+"CountrySelectionInfo";
            }

            
        }
    }
}