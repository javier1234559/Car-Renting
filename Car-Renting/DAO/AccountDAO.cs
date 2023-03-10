using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class AccountDAO
    {
        public DataTable getListAccount()
        {
            string sqlStr = string.Format("SELECT * FROM Account");
            return DbConnection.Instance.getData(sqlStr);

        }

        public int Them(Account acc)
        {
            string sqlStr = string.Format("INSERT INTO Account (AccID, Email, Password, IdUser) VALUES ({0},{1},{2},{3})", acc.AccID, acc.Email, acc.Password, acc.IdUser);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

    }
}
