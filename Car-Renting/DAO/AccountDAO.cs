using Car_Renting;
using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Renting
{
    class AccountDAO : IBaseDAO<Account>
    {

        public DataTable GetAllDataTable()
        {
            var sql = @"SELECT * FROM Account";

            return DbConnection.Instance.getData(sql);
        }

        public Account GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Account");
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            DataRow[] result = dt.Select($"AccID = {id}");
            if (result.Length > 0)  
            {
                DataRow row = result[0];
                Account Account = new Account
                {
                    AccID = (int)row["AccID"],
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    IdUser = (int)row["IdUser"]
                };
                return Account;
            }
            return null;
        }

        public int Insert(Account entity)
        {
            string sqlStr = "";
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        public int Delete(Account entity)
        {
            string sqlStr = string.Format("delete from Accounts where AccountId = '{0}'", entity.AccID);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        public int Update(Account entity)
        {
            string sqlStr = "";
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

    }
}
