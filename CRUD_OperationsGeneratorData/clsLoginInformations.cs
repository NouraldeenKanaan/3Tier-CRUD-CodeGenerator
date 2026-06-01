using Microsoft.Data.SqlClient;

namespace CRUD_OperationsGeneratorData
{
    public static class clsLoginInformations
    {
        public static async Task<List<string>> GetDatabses()
        {
            List<string> Databases = new List<string>();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(clsAppConfigurations.ConnectionString))
                {
                    await connection.OpenAsync();

                    string query = @"SELECT name FROM sys.databases WHERE database_id > 4;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    Databases.Add(reader.GetString(0));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return Databases;
        }
        //public static DataTable GetDatabaseTables(string ConnectionString)
        //{
        //    DataTable dtDatabaseTables = new DataTable();

        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(ConnectionString))
        //        {
        //            connection.Open();

        //            string query = @"SELECT  TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE';";

        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    if (reader.HasRows)
        //                        dtDatabaseTables.Load(reader);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //    return dtDatabaseTables;
        //}
    }
}
