

namespace CRUD_OperationsGeneratorBusiness
{
    public static class clsGlobal
    {
        public static string DataBaseName { set; get; }
        public static string SingleTableName { set; get; }
        public static string TableName { set; get; }
        public static List<clsColumn> Columns { set; get; } = new List<clsColumn>();
    }
}
