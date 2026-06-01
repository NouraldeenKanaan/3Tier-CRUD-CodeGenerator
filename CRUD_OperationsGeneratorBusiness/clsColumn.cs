namespace CRUD_OperationsGeneratorBusiness
{
    public class clsColumn
    {
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public bool IsNull { get; set; }
        public bool IsPK { get; set; }

        public clsColumn(string ColumnName, string ColumnDataType, bool IsPK, bool IsNull)
        {
            this.ColumnName = ColumnName;
            this.ColumnDataType = ColumnDataType;
            this.IsPK = IsPK;
            this.IsNull = IsNull;
        }
    }
}
