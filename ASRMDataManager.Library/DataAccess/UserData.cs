using ASRMDataManager.Library.Internal.DataAccess;
using ASRMDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRMDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new {id };
            var output = sql.LoadData<UserModel,dynamic>("dbo.spUserLookup",p,"ASRMData");
            return output;  
        }
    }
}
