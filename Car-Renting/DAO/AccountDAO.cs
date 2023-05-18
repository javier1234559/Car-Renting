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
    class AccountDAO : BaseDAO<Account>
    {
       //--------------- Extends Methods ---------------- 
        public DataTable GetFullDataUser()
        {
            string sql = "SELECT Users.IdUser, Users.Name, Users.Phone, Users.Address, Users.TotalRevenue, Account.AccID, Account.Email, Account.Password " +
                         "FROM Users " +
                         "JOIN Account ON Users.IdUser = Account.IdUser";

            return DbConnection.Instance.getData(sql);
        }

        public DataTable SearchFullDataUser(string keyword)
        {
            string sql = "SELECT Users.IdUser, Users.Name, Users.Phone, Users.Address, Users.TotalRevenue, Account.AccID, Account.Email, Account.Password " +
                         "FROM Users " +
                         "JOIN Account ON Users.IdUser = Account.IdUser " +
                         "WHERE Users.Name LIKE '%" + keyword + "%' OR Users.Phone LIKE '%" + keyword + "%' OR Account.Email LIKE '%" + keyword + "%'";

            return DbConnection.Instance.getData(sql);
        }

        public  Account GetByEmailAndPass(string email , string pass)
        {
            string query = $"SELECT * FROM Account WHERE Email = '{email}' and Password = '{pass}';";
            DataTable dt = DbConnection.Instance.getData(query);
            DataRow[] result = dt.Select($"Email = '{email}'");
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


        //--------------- Override Methods ---------------- 
        public override DataTable GetAllDataTable()
        {
            var sql = @"SELECT * FROM Account";

            return DbConnection.Instance.getData(sql);
        }

        public override Account GetById(int id)
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

        public override int Insert(Account entity)
        {
            string sqlStr = "INSERT INTO Account (Email, Password, IdUser) VALUES (@Email, @Password, @IdUser); SELECT SCOPE_IDENTITY()";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Email", entity.Email);
            parameters.Add("@Password", entity.Password);
            parameters.Add("@IdUser", entity.IdUser);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
        }

        public override int Delete(Account entity)
        {
            string sqlStr = "DELETE FROM Account WHERE AccID = @AccID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccID", entity.AccID);

            int rowsAffected = DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);

            return rowsAffected;
        }

        public override int Update(Account entity)
        {
            string sqlStr = "UPDATE Account SET Email = @Email, Password = @Password WHERE AccID = @AccID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccID", entity.AccID);
            parameters.Add("@Email", entity.Email);
            parameters.Add("@Password", entity.Password);

            int rowsAffected = DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);

            return rowsAffected;
        }

    }
}
