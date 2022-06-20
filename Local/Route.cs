namespace Portfolio.Route
{
    public static class RialPayRoute
    {
        private const string BASE = "Portfolio/";

        public static class API 
        {
            private const string NAME      = "API";
            public const string FULL_NAME = BASE + NAME;

            public static class Skills { 
                private const string BASESKILL = "SKILL/";
                public const string LIST = BASESKILL+"LIST";
            }

            public static class Education
            {
                private const string BASESKILL = "EDUCATION/";
                public const string LIST = BASESKILL + "LIST";
            }

            public static class Experience
            {
                private const string BASESKILL = "EXPERIENCE/";
                public const string LIST = BASESKILL + "LIST";
            }
        }

    }
}