namespace Crud_ADO_Code
{
    public static class ConnectionString
    {
        private static string cs = "server=DELL\\SQLEXPRESS; database=CrudADOdb; trusted_connection=true; trustservercertificate=true;";
        public static string dbcs { get => cs; }
    }
}
