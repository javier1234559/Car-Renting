using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class ClientDAO
    {
        public DataTable getListClient()
        {
            string sqlStr = string.Format("SELECT * FROM Clients");
            return DbConnection.Instance.getData(sqlStr);

        }

        //public int Them(Client cli)
        //{
        //    string sqlStr = string.Format("INSERT INTO Clients (AccID, Email, Password, IdUser) VALUES ({0},{1},{2},{3})", acc.AccID, acc.Email, acc.Password, acc.IdUser);
        //    return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        //}
    }
}
