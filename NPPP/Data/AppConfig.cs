namespace NPPP.Data
{
    public static class AppConfig
    {
       
        internal static string ConnectionString;

        internal static int PageSize; 

        internal static void SetConnectionString(string connectionString)
        {
            if (connectionString != null) { ConnectionString = connectionString; }
        }

        internal static void SetPageSize(int pageSize)
        {
            if (pageSize != null) { PageSize = pageSize; }
        }


    }
}
