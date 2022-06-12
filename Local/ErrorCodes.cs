namespace Portfolio.Exceptions
{
    public static class ErrorCodes
    {
        public static class AccessObject
        {
            public const int DA_DAO_ALI_access = 500_01_00_00;
            public const int DA_DAO_GM_method  = 500_01_01_00;

            public const int DA_SRAO_ATR_usNull    = 500_02_00_00;
            public const int DA_SRAO_ATR_srNull    = 500_02_00_01;
            public const int DA_SRAO_ATRs_usNull   = 500_02_01_00;
            public const int DA_SRAO_ATRs_srNull   = 500_02_01_01;
            public const int DA_SRAO_ATRs_usrNull  = 500_02_01_02;
            public const int DA_SRAO_GR_usNull     = 500_02_02_00;
            public const int DA_SRAO_GR_srNull     = 500_02_02_01;
            public const int DA_SRAO_IIR_usNull    = 500_02_03_00;
            public const int DA_SRAO_RFR_usNull    = 500_02_04_00;
            public const int DA_SRAO_RFR_usrNull   = 500_02_04_01;
            public const int DA_SRAO_RFRs_usNull   = 500_02_05_00;
            public const int DA_SRAO_RFRs_usrNull  = 500_02_05_01;
            public const int DA_SRAO_RFRs2_usNull  = 500_02_06_00;
            public const int DA_SRAO_RFRs2_srNull  = 500_02_06_01;
            public const int DA_SRAO_RFRs2_usrNull = 500_02_06_02;
        }
    }
}