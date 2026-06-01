using CRUD_OperationsGeneratorData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_OperationsGeneratorBusiness
{
    public class clsLoginInfo
    {
        public static async Task<List<string>> GetDatabases()
        {
            return await clsLoginInformations.GetDatabses();
        }
    }
}
