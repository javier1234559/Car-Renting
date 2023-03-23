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
       
        public DataTable GetAllDataTable() {
            string sqlStr = string.Format("SELECT * FROM Clients");
            return DbConnection.Instance.getData(sqlStr);
        }

        public Client GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Clients WHERE ClientId={0}", id);
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Client client = new Client
                {
                    ClientId = (int)row["ClientId"],
                    Name = row["Name"].ToString(),
                    Phone = row["Phone"].ToString(),
                    CCCD = row["CCCD"].ToString(),
                    Email = row["Email"].ToString(),
                    License = row["License"].ToString()
                };
                return client;
            }
            return null;
        }

<<<<<<< HEAD
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
        public Client getIdwithCMND(string cccd )
        {
            string sqlStr = string.Format("select ClientId from Clients where  CCCD={0} ",cccd);
=======
        public Client FindIDClientByCmnd(string CMND)
        {
            string sqlStr = string.Format("select ClientId from Clients where  CCCD='{0}' ", CMND);
>>>>>>> main
            DataTable dt = DbConnection.Instance.getData(sqlStr);
            Client client = new Client();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                client=GetById((int)row["ClientId"]);
                return client;
            }
<<<<<<< HEAD
=======

            return null;
        }
>>>>>>> main

            return null;
        }
        public int Insert(Client entity)
        {
            string sqlStr = string.Format("INSERT INTO Clients (Name, Phone, CCCD, Email, License) VALUES (@Name, @Phone, @CCCD, @Email, @License); SELECT SCOPE_IDENTITY()");

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", entity.Name);
            parameters.Add("@Phone", entity.Phone);
            parameters.Add("@CCCD", entity.CCCD);
            parameters.Add("@Email", entity.Email);
            parameters.Add("@License", entity.License);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
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
