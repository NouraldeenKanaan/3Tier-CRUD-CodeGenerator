
using System.Text;

namespace CRUD_OperationsGeneratorBusiness
{
    public class clsUtility
    {
        public static string GetParametersWithDataTypesAndPK(List<clsColumn> Columns, string Prefix = "")
        {
            StringBuilder sb = new StringBuilder();

            foreach (clsColumn column in Columns)
            {
                sb.Append($"{Prefix}{column.ColumnDataType} {column.ColumnName},");
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
        public static string GetParameters(List<clsColumn> Columns, string Prefix = "")
        {
            StringBuilder sb = new StringBuilder();

            foreach (clsColumn column in Columns)
            {
                sb.Append($"{Prefix}{column.ColumnName},");
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

        public static string CreateCommands(List<clsColumn> columns)
        {
            StringBuilder sb = new StringBuilder();

            foreach (clsColumn column in columns)
            {
                if (column.IsPK == true)
                    continue;

                if (column.IsNull == true && column.ColumnDataType == "string")
                {
                    sb.Append($@"
                        if({column.ColumnName} == """")
                        command.Parameters.AddWithValue(""@{column.ColumnName}"", DBNull.Value);
                        else
                        command.Parameters.AddWithValue(""@{column.ColumnName}"",dto.{column.ColumnName});");

                }
                else
                {
                    sb.Append($@"
                        command.Parameters.AddWithValue(""@{column.ColumnName}"",dto.{column.ColumnName});");
                }

            }

            return sb.ToString();
        }
        public static string UpdateCommands(List<clsColumn> columns)
        {
            StringBuilder sb = new StringBuilder();

            foreach (clsColumn column in columns)
            {
                if (column.IsNull == true && column.ColumnDataType == "string")
                {
                    sb.Append($@"
                        if({column.ColumnName} == """")
                        command.Parameters.AddWithValue(""@{column.ColumnName}"", DBNull.Value);
                        else
                        command.Parameters.AddWithValue(""@{column.ColumnName}"",dto.{column.ColumnName});");
                }
                else
                {
                    sb.Append($@"
                        command.Parameters.AddWithValue(""@{column.ColumnName}"",dto.{column.ColumnName});");
                }

            }

            return sb.ToString();
        }
        public static string HandleFindByID(List<clsColumn> columns)
        {
            StringBuilder sb = new StringBuilder();

            foreach (clsColumn column in columns)
            {
                if (column.IsPK) continue;

                if (column.IsNull && column.ColumnDataType == "string")
                {
                    sb.Append($@"
                       if (reader[""{column.ColumnName}""] == DBNull.Value) // Corrected Case
                            string {column.ColumnName} = """";
                        else
                            string{column.ColumnName} = ({column.ColumnDataType})reader[""{column.ColumnName}""];");
                }
                else
                {
                    sb.Append($@"
                            {column.ColumnDataType} {column.ColumnName} = ({column.ColumnDataType})reader[""{column.ColumnName}""];");
                }
            }
            return sb.ToString();
        }
    }
}
