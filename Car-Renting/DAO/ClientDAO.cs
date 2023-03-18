using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class ClientDAO : IBaseDAO<Client>
    {
        public List<Client> GetAllList() {
            List<Client> list = new List<Client>();

            return list;
        }

        public DataTable GetAllDataTable() {
            string sqlStr = string.Format("SELECT * FROM Clients");
            return DbConnection.Instance.getData(sqlStr);
        }

        public Client GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Clients");
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            DataRow[] result = dt.Select($"ClientId = {id}");
            if (result.Length > 0)
            {
                DataRow row = result[0];
                Client client = new Client
                {
                    ClientId = (int)row["ClientId"],
                    Name = row["Name"].ToString(),
                    Phone = (int)row["Phone"],
                    CCCD = (int)row["CCCD"],
                    Email = row["Email"].ToString(),
                };
                return client;
            }
            return null;
        }

        //public int FindIDClientByNumberPhone(int numberphone){
        //    int value = 0;
        //    string sqlStr = $"SELECT TOP 1 * FROM Clients WHERE Phone = '{numberphone}';";
        //    DataTable dt = DbConnection.Instance.getData(sqlStr);
        //    DataRow[] result = dt.Select($"Phone = {numberphone}");
        //    if (result.Length > 0)
        //    {   
        //        value = (int)result[0]["ClientId"];
        //        return value;
        //    }
        //    return value;
        //}

        public int Insert(Client entity)
        {
            string sqlStr = string.Format("INSERT INTO Clients (ClientId, Name, Phone, CCCD, Email) VALUES ({0},{1},{2},{3})", entity.ClientId, entity.Name, entity.Phone, entity.CCCD, entity.Email);
            //string sqlStr = $"INSERT INTO Clients (ClientId, Name, Phone, CCCD, Email)" +
            //                $"VALUES ({entity.ClientId}, {entity.Name}, {entity.Phone}, {entity.CCCD}, {entity.Email})";
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        public int Delete(Client entity)
        {
            string sqlStr = string.Format("delete from Clients where Ten = '{0}'", entity.ClientId);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        public int Update(Client entity)
        {
            string sqlStr = string.Format("update Client set Email = '{0}' where Ten = '{1}'", entity.Email, entity.ClientId);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }
    }
}
