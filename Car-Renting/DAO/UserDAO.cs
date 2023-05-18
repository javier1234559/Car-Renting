using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class UserDAO : BaseDAO<User>
    {
        //--------------- Extends Methods ---------------- 
        public List<User> GetAllDateList()
        {
            string sqlStr = string.Format("SELECT * FROM Users ");
            DataTable dt = DbConnection.Instance.getData(sqlStr);
            List<User> list = new List<User>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    User user = new User
                    {
                        IdUser = (int)row["IdUser"],
                        Name = row["Name"].ToString(),
                        Phone = row["Phone"].ToString(),
                        Address = row["Address"].ToString(),
                        TotalRevenue = (int)row["TotalRevenue"]
                    };
                    list.Add(user);
                }
                return list;
            }
            return null;
        }

        public DataTable GetDataTableByDay(DateTime day , int iduser)
        {
            string dayStr = day.ToString("dd");
            string sqlStr = $"SELECT * FROM Bills WHERE DATEPART(day, CreateDate) = '{dayStr}' and IdUser = {iduser}";
            return DbConnection.Instance.getData(sqlStr);
        }

        public DataTable GetDataTableByMonth(DateTime month, int iduser)
        {
            string dayStr = month.ToString("MM");
            string sqlStr = $"SELECT * FROM Bills WHERE DATEPART(month, CreateDate) = '{dayStr}' and IdUser = {iduser}";
            return DbConnection.Instance.getData(sqlStr);
        }

        public DataTable GetDataTableByYear(DateTime year, int iduser)
        {
            string dayStr = year.ToString("yyyy");
            string sqlStr = $"SELECT * FROM Bills WHERE DATEPART(year, CreateDate) = '{dayStr}' and IdUser =  {iduser}";
            return DbConnection.Instance.getData(sqlStr);
        }

        public User GetByPhone(string phone)
        {
            string sqlStr = string.Format("SELECT * FROM Users WHERE Phone ={0}", phone);
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                User user = new User
                {
                    IdUser = (int)row["IdUser"],
                    Name = row["Name"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Address = row["Address"].ToString(),
                    TotalRevenue = (int)row["TotalRevenue"]
                };
                return user;
            }
            return null;
        }

        //--------------- Override Methods ---------------- 

        public override DataTable GetAllDataTable()
        {
            string sqlStr = "SELECT * FROM Users";
            return DbConnection.Instance.getData(sqlStr);
        }

        public override User GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Users WHERE IdUser={0}", id);
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                User user = new User
                {
                    IdUser = (int)row["IdUser"],
                    Name = row["Name"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Address = row["Address"].ToString(),
                    TotalRevenue = (int)row["TotalRevenue"]
                };
                return user;
            }
            return null;
        }

        public override int Insert(User entity)
        {
            string sqlStr = "INSERT INTO Users (Name, Phone, Address, TotalRevenue) VALUES (@Name, @Phone, @Address, @TotalRevenue); SELECT SCOPE_IDENTITY()";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", entity.Name);
            parameters.Add("@Phone", entity.Phone);
            parameters.Add("@Address", entity.Address);
            parameters.Add("@TotalRevenue", entity.TotalRevenue);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
        }

        public override int Update(User entity)
        {
            string sqlStr = "UPDATE Users SET Name = @Name, Phone = @Phone, Address = @Address, TotalRevenue = @TotalRevenue WHERE IdUser = @IdUser";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Name", entity.Name);
            parameters.Add("@Phone", entity.Phone);
            parameters.Add("@Address", entity.Address);
            parameters.Add("@TotalRevenue", entity.TotalRevenue);
            parameters.Add("@IdUser", entity.IdUser);

            return DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);
        }

        public override int Delete(User entity)
        {
            string sqlStr = "DELETE FROM Users WHERE IdUser = @IdUser";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@IdUser", entity.IdUser);

            int rowsAffected = DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);

            return rowsAffected;
        }
    }
}
