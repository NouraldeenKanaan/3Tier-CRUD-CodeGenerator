using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OperationsGeneratorBusiness
{
    public class GenerateDataLayer
    {
        public static string Generate()
        {
            var pkCol = clsGlobal.Columns.FirstOrDefault(c => c.IsPK) ?? clsGlobal.Columns[0];
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace {clsGlobal.DataBaseName}Data
{{
    public class {clsGlobal.SingleTableName}DTO
    {{
        {_GenerateDtoProperties()}

        public {clsGlobal.SingleTableName}DTO({clsUtility.GetParametersWithDataTypesAndPK(clsGlobal.Columns)})
        {{
            {_GenerateDtoConstructorAssignments()}
        }}
    }}

    public static class cls{clsGlobal.TableName}Data
    {{
        {Read()} 
        {Create()}
        {Update()}
        {Delete()}
        {FindByID()}
    }}
}}");

            return sb.ToString();
        }

        private static string _GenerateDtoProperties()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var col in clsGlobal.Columns)
            {
                sb.Append($@"
        public {col.ColumnDataType} {col.ColumnName} {{ get; set; }}");
            }
            return sb.ToString();
        }

        private static string _GenerateDtoConstructorAssignments()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var col in clsGlobal.Columns)
            {
                sb.Append($@"
            this.{col.ColumnName} = {col.ColumnName};");
            }
            return sb.ToString();
        }

        private static string FindByID()
        {
            var pkCol = clsGlobal.Columns.FirstOrDefault(c => c.IsPK) ?? clsGlobal.Columns[0];
            string spName = $"SP_Get{clsGlobal.SingleTableName}ByID";
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public static async Task<{clsGlobal.SingleTableName}DTO> Get{clsGlobal.SingleTableName}InfoByID({pkCol.ColumnDataType} {pkCol.ColumnName})
        {{
            {clsGlobal.SingleTableName}DTO dto = null;

            try
            {{
                using (SqlConnection connection = new SqlConnection(clsAppConfigurations.ConnectionString))
                {{
                    using (SqlCommand command = new SqlCommand(""{spName}"", connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(""@{pkCol.ColumnName}"", {pkCol.ColumnName});

                        await connection.OpenAsync();

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {{
                            if (await reader.ReadAsync())
                            {{
                                 {clsUtility.HandleFindByID(clsGlobal.Columns)}

                                dto = new {clsGlobal.SingleTableName}DTO({clsUtility.GetParameters(clsGlobal.Columns)});
                            }}
                        }}
                    }}
                }}
            }}
            catch (Exception)
            {{
                throw;
            }}

            return dto;
        }}");

            return sb.ToString();
        }

        private static string Create()
        {
            string spName = $"SP_Create{clsGlobal.SingleTableName}";
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public static async Task<int> Create{clsGlobal.SingleTableName}({clsGlobal.SingleTableName}DTO dto)
        {{
            int newID = -1;

            try
            {{
                using (SqlConnection connection = new SqlConnection(clsAppConfigurations.ConnectionString))
                {{
                    using (SqlCommand command = new SqlCommand(""{spName}"", connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;
                        {clsUtility.CreateCommands(clsGlobal.Columns)}

                        await connection.OpenAsync();
                        object result = await command.ExecuteScalarAsync();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {{
                            newID = insertedID;
                        }}
                    }}
                }}
            }}
            catch (Exception)
            {{
                throw;
            }}

            return newID;
        }}");

            return sb.ToString();
        }

        private static string Read()
        {
            string spName = $"SP_GetAll{clsGlobal.TableName}";
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public static async Task<List<{clsGlobal.SingleTableName}DTO>> Read{clsGlobal.TableName}()
        {{
            var list = new List<{clsGlobal.SingleTableName}DTO>();

            try
            {{
                using (SqlConnection connection = new SqlConnection(clsAppConfigurations.ConnectionString))
                {{
                    using (SqlCommand command = new SqlCommand(""{spName}"", connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;

                        await connection.OpenAsync();

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {{
                            while (await reader.ReadAsync())
                            {{
                                list.Add(new {clsGlobal.SingleTableName}DTO(
                                    {_GenerateReaderParameters()}
                                ));
                            }}
                        }}
                    }}
                }}
            }}
            catch (Exception)
            {{
                throw;
            }}

            return list;
        }}");

            return sb.ToString();
        }

        private static string _GenerateReaderParameters()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < clsGlobal.Columns.Count; i++)
            {
                var col = clsGlobal.Columns[i];
                if (col.IsNull && col.ColumnDataType.ToLower() == "string")
                {
                    sb.Append($"reader[\"{col.ColumnName}\"] == DBNull.Value ? \"\" : (string)reader[\"{col.ColumnName}\"]");
                }
                else
                {
                    sb.Append($"({col.ColumnDataType})reader[\"{col.ColumnName}\"]");
                }
                if (i < clsGlobal.Columns.Count - 1) sb.Append(",\n                                    ");
            }
            return sb.ToString();
        }

        private static string Update()
        {
            string spName = $"SP_Update{clsGlobal.SingleTableName}";
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public static async Task<bool> Update{clsGlobal.SingleTableName}({clsGlobal.SingleTableName}DTO dto)
        {{
            int rowsAffected = 0;

            try
            {{
                using (SqlConnection connection = new SqlConnection(clsAppConfigurations.ConnectionString))
                {{
                    using (SqlCommand command = new SqlCommand(""{spName}"", connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;
                        {clsUtility.UpdateCommands(clsGlobal.Columns)}

                        await connection.OpenAsync();
                        rowsAffected = await command.ExecuteNonQueryAsync();
                    }}
                }}
            }}
            catch (Exception)
            {{
                throw;
            }}

            return (rowsAffected > 0);
        }}");

            return sb.ToString();
        }

        private static string Delete()
        {
            var pkCol = clsGlobal.Columns.FirstOrDefault(c => c.IsPK) ?? clsGlobal.Columns[0];
            string spName = $"SP_Delete{clsGlobal.SingleTableName}";
            StringBuilder sb = new StringBuilder();

            sb.Append($@"
        public static async Task<bool> Delete{clsGlobal.SingleTableName}({pkCol.ColumnDataType} {pkCol.ColumnName})
        {{
            int rowsAffected = 0;

            try
            {{
                using (SqlConnection connection = new SqlConnection(clsAppConfigurations.ConnectionString))
                {{
                    using (SqlCommand command = new SqlCommand(""{spName}"", connection))
                    {{
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(""@{pkCol.ColumnName}"", {pkCol.ColumnName});

                        await connection.OpenAsync();
                        rowsAffected = await command.ExecuteNonQueryAsync();
                    }}
                }}
            }}
            catch (Exception)
            {{
                throw;
            }}

            return (rowsAffected > 0);
        }}");

            return sb.ToString();
        }

        private static string _GenerateLocalVariablesDeclarations()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var col in clsGlobal.Columns)
            {
                if (col.IsPK)
                    continue;

                string defaultValue = col.ColumnDataType.ToLower() == "string" ? "\"\"" : $"default({col.ColumnDataType})";
                sb.AppendLine($"                                {col.ColumnDataType} {col.ColumnName} = {defaultValue};");
            }
            return sb.ToString();
        }
    }
    public class GenerateBusinessLayer
    {
        public static string Generate()
        {
            var pkCol = clsGlobal.Columns.FirstOrDefault(c => c.IsPK) ?? clsGlobal.Columns[0];
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($@"using System;
using System.Collections.Generic;
using {clsGlobal.DataBaseName}Data;

namespace {clsGlobal.DataBaseName}Business
{{
    public class cls{clsGlobal.SingleTableName}
    {{
        public enum enMode {{ AddNew = 0, Update = 1 }}
        public enMode Mode = enMode.AddNew;
        {_GenerateProperties()}

        public {clsGlobal.SingleTableName}DTO DTO
        {{
            get => new {clsGlobal.SingleTableName}DTO({clsUtility.GetParameters(clsGlobal.Columns, "this.")});
        }}

        public cls{clsGlobal.SingleTableName}()
        {{
            {_GenerateConstructorDefaults()}
            Mode = enMode.AddNew;
        }}

        private cls{clsGlobal.SingleTableName}({clsGlobal.SingleTableName}DTO dto)
        {{
            {_GenerateConstructorFromDto()}
            Mode = enMode.Update;
        }}

        public static async Task<cls{clsGlobal.SingleTableName}> FindAsync({pkCol.ColumnDataType} {pkCol.ColumnName})
        {{
            {clsGlobal.SingleTableName}DTO dto = await cls{clsGlobal.TableName}Data.Get{clsGlobal.SingleTableName}InfoByID({pkCol.ColumnName});

            if (dto != null)
            {{
                return new cls{clsGlobal.SingleTableName}(dto);
            }}

            return null;
        }}

        public async Task<bool> SaveAsync()
        {{
            switch (Mode)
            {{
                case enMode.AddNew:
                    if (await _AddNewAsync())
                    {{
                        Mode = enMode.Update;
                        return true;
                    }}
                    return false;

                case enMode.Update:
                    return await _UpdateAsync();
            }}

            return false;
        }}

        private async Task<bool> _AddNewAsync()
        {{
            this.{pkCol.ColumnName} = await cls{clsGlobal.TableName}Data.Create{clsGlobal.SingleTableName}(this.DTO);
            return (this.{pkCol.ColumnName} != -1);
        }}

        private async Task<bool> _UpdateAsync()
        {{
            return await cls{clsGlobal.TableName}Data.Update{clsGlobal.SingleTableName}(this.DTO);
        }}

        public static async Task<List<{clsGlobal.SingleTableName}DTO>> GetAllAsync()
        {{
            return await cls{clsGlobal.TableName}Data.Read{clsGlobal.TableName}();
        }}

        public static async Task<bool> DeleteAsync({pkCol.ColumnDataType} {pkCol.ColumnName})
        {{
            return await cls{clsGlobal.TableName}Data.Delete{clsGlobal.SingleTableName}({pkCol.ColumnName});
        }}
    }}
}}");

            return sb.ToString();
        }

        private static string _GenerateProperties()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var col in clsGlobal.Columns)
            {
                sb.Append($@"
        public {col.ColumnDataType} {col.ColumnName} {{ get; set; }}");
            }
            return sb.ToString();
        }

        private static string _GenerateConstructorDefaults()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var col in clsGlobal.Columns)
            {
                sb.Append($@"
            this.{col.ColumnName} = {_FillMembersWithDataType(col.ColumnDataType)};");
            }
            return sb.ToString();
        }

        private static string _GenerateConstructorFromDto()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var col in clsGlobal.Columns)
            {
                sb.Append($@"
            this.{col.ColumnName} = dto.{col.ColumnName};");
            }
            return sb.ToString();
        }

        private static string _FillMembersWithDataType(string columnDataType)
        {
            switch (columnDataType.ToLower())
            {
                case "string": return "\"\"";
                case "char": return "' '";
                case "bool": return "false";
                case "date":
                case "datetime": return "DateTime.Now";
                default: return "-1";
            }
        }
    }
    public class clsGenerateCRUD
    {
        public clsGenerateCRUD(string databaseName)
        {
            clsGlobal.DataBaseName = databaseName;
        }

        public static async Task Generate()
        {
            await Task.Run(() =>
            {
                _SaveClass(GenerateBusinessLayer.Generate(), $"cls{clsGlobal.SingleTableName}");
                _SaveClass(GenerateDataLayer.Generate(), $"cls{clsGlobal.TableName}Data");
            });
        }

        private static void _SaveClass(string classContent, string className)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "BusinessAndDataAccessLayers");
            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, $"{className}.cs");
            File.WriteAllText(filePath, classContent);
        }
    }
}
