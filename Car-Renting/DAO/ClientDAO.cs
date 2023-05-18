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
    class ClientDAO : BaseDAO<Client>
    {
        //--------------- Extends Methods ---------------- 
        public DataTable Search(string keyword)
        {
            string sqlQuery = string.Format("SELECT * FROM Clients WHERE Name LIKE '%{0}%' OR Phone LIKE '%{0}%' OR Email LIKE '%{0}%' OR CCCD LIKE '%{0}%'", keyword);
            return DbConnection.Instance.getData(sqlQuery);
        }

        public Client FindIDClientByCmnd(string CMND)
        {
            string sqlStr = string.Format("select ClientId from Clients where  CCCD ='{0}' ", CMND);
            DataTable dt = DbConnection.Instance.getData(sqlStr);
            Client client = new Client();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                client=GetById((int)row["ClientId"]);
                return client;
            }

            return null;
        }

        //--------------- Override Methods ---------------- 

        public override DataTable GetAllDataTable()
        {
            string sqlStr = string.Format("SELECT * FROM Clients");
            return DbConnection.Instance.getData(sqlStr);
        }

        public override Client GetById(int id)
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

        public override int Insert(Client entity)
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

        public override int Update(Client entity)
        {
            string sqlStr = "UPDATE Clients SET Name = @Name, Phone = @Phone, CCCD = @CCCD, Email = @Email, License = @License WHERE ClientId = @ClientId";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", entity.Name);
            parameters.Add("@Phone", entity.Phone);
            parameters.Add("@CCCD", entity.CCCD);
            parameters.Add("@Email", entity.Email);
            parameters.Add("@License", entity.License);
            parameters.Add("@ClientId", entity.ClientId);

            return DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);

        }

        public override int Delete(Client entity)
        {
            string sqlStr = string.Format("delete from Clients where ClientId = '{0}'", entity.ClientId);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }
        
    }
}
