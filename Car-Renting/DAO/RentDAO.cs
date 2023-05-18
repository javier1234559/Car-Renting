using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.IO.Util.IntHashtable;

namespace Car_Renting
{
    class RentDAO : BaseDAO<Rent>
    {
        //--------------- Extends Methods ---------------- 
        public DataTable SearchTwoState(string keyword , string state1, string state2)
        {
            string sqlStr = string.Format("SELECT Rents.RentId, Rents.State , Cars.ImageCar, Cars.CarName, Cars.NumberPlate, Clients.Name, DateStart, DateEnd, State, DateDelayQuantity, Deposit, CanceleReason, Cars.CategoryName AS CategoryName , Rents.DescriptionRent " +
                                           "FROM Rents " +
                                           "INNER JOIN Cars ON Rents.CarId = Cars.CarId " +
                                           "INNER JOIN Clients ON Rents.ClientId = Clients.ClientId " +
                                           "WHERE (Cars.CarName LIKE '%{0}%' OR Clients.Name LIKE '%{0}%') " +
                                           "AND State IN ('{1}', '{2}')", keyword, state1, state2);
            return DbConnection.Instance.getData(sqlStr);
        }

        public DataTable Search(string keyword, string state)
        {
            string sqlStr = string.Format("SELECT Rents.RentId, Rents.State , Cars.ImageCar, Cars.CarName, Cars.NumberPlate, Clients.Name, DateStart, DateEnd, State, DateDelayQuantity, Deposit, CanceleReason, Cars.CategoryName AS CategoryName , Rents.DescriptionRent " +
                                           "FROM Rents " +
                                           "INNER JOIN Cars ON Rents.CarId = Cars.CarId " +
                                           "INNER JOIN Clients ON Rents.ClientId = Clients.ClientId " +
                                           "WHERE (Cars.CarName LIKE '%{0}%' OR Clients.Name LIKE '%{0}%') " +
                                           "AND State IN ('{1}')", keyword, state);
            return DbConnection.Instance.getData(sqlStr);
        }
     
        public DataTable GetAllDataTableByState(string state)
        {
            string sqlStr = string.Format("SELECT Rents.RentId, Rents.State, Cars.ImageCar, Cars.CarName, Cars.NumberPlate, Clients.Name, DateStart, DateEnd, State, DateDelayQuantity, Deposit, CanceleReason, Cars.CategoryName AS CategoryName , Rents.DescriptionRent FROM Rents, Cars, Clients WHERE Rents.CarId = Cars.CarId AND Rents.ClientId = Clients.ClientId AND State = '{0}'", state);
            return DbConnection.Instance.getData(sqlStr);
        }

        public DataTable GetAllDataTableTwoStates(string state1, string state2)
        {
            string sqlStr = string.Format("SELECT Rents.RentId, Rents.State , Cars.ImageCar, Cars.CarName, Cars.NumberPlate, Clients.Name, DateStart, DateEnd, State, DateDelayQuantity, Deposit, CanceleReason, Cars.CategoryName AS CategoryName , Rents.DescriptionRent FROM Rents, Cars, Clients WHERE Rents.CarId = Cars.CarId AND Rents.ClientId = Clients.ClientId AND State IN ('{0}', '{1}')", state1, state2);
            return DbConnection.Instance.getData(sqlStr);
        }

        public void  ChangeState (int rentID, string state)
        {
            string sqlStr = $"UPDATE Rents SET State = @State WHERE RentId = @RentId";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@RentId", rentID);
            parameters.Add("@State", state);

            DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);
        }

        //--------------- Override Methods ---------------- 

        public override DataTable GetAllDataTable()
        {
            string sqlStr = string.Format("select Rents.RentId,Cars.CarName,Clients.Name,DateStart,DateEnd,State,DateDelayQuantity,Deposit,CanceleReason,Cars.CategoryName as CategoryName ,Rents.DescriptionRent from Rents, Cars, Clients where Rents.CarId = Cars.CarId and Rents.ClientId = Clients.ClientId ");
            return DbConnection.Instance.getData(sqlStr);
        }

        public override Rent GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Rents");
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            DataRow[] result = dt.Select($"RentId = {id}");
            if (result.Length > 0)
            {
                Rent rent = new Rent();
                rent.RentId = Int32.Parse(result[0]["RentId"].ToString());
                rent.CarId = Int32.Parse(result[0]["CarId"].ToString());
                rent.ClientId = Int32.Parse(result[0]["ClientId"].ToString());
                rent.DateStart = DateTime.Parse(result[0]["DateStart"].ToString());
                rent.DateEnd = DateTime.Parse(result[0]["DateEnd"].ToString());
                rent.DateDelayQuantity = Int32.Parse(result[0]["DateDelayQuantity"].ToString());
                rent.State = result[0]["State"].ToString();
                rent.DescriptionRent = result[0]["DescriptionRent"].ToString();
                rent.Deposit = Int32.Parse(result[0]["Deposit"].ToString());

                return rent;
            }
            else
            {
                return null;
            }
        }

        public override int Insert(Rent entity)
        {
            string sqlStr = "INSERT INTO Rents(CarId, ClientId, DateStart, DateEnd, DateDelayQuantity, State, DescriptionRent, Deposit) " +
                   "VALUES (@CarId, @ClientId, @DateStart, @DateEnd, @DateDelayQuantity, @State, @DescriptionRent, @Deposit); " +
                   "SELECT CAST(scope_identity() AS int)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CarId", entity.CarId);
            parameters.Add("@ClientId", entity.ClientId);
            parameters.Add("@DateStart", entity.DateStart);
            parameters.Add("@DateEnd", entity.DateEnd);
            parameters.Add("@DateDelayQuantity", entity.DateDelayQuantity);
            parameters.Add("@State", entity.State);
            parameters.Add("@DescriptionRent", entity.DescriptionRent);
            parameters.Add("@Deposit", entity.Deposit);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
        }

        public override int Update(Rent entity)
        {
            string sqlStr = "UPDATE Rents SET CarId = @CarId, ClientId = @ClientId, DateStart = @DateStart, DateEnd = @DateEnd, DateDelayQuantity = @DateDelayQuantity, State = @State, DescriptionRent = @DescriptionRent, Deposit = @Deposit WHERE RentId = @RentId";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CarId", entity.CarId);
            parameters.Add("@ClientId", entity.ClientId);
            parameters.Add("@DateStart", entity.DateStart);
            parameters.Add("@DateEnd", entity.DateEnd);
            parameters.Add("@DateDelayQuantity", entity.DateDelayQuantity);
            parameters.Add("@State", entity.State);
            parameters.Add("@DescriptionRent", entity.DescriptionRent);
            parameters.Add("@Deposit", entity.Deposit);
            parameters.Add("@RentId", entity.RentId);

            return DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);
        }

        public override int Delete(Rent entity)
        {
            throw new NotImplementedException();
        }
    }
}
