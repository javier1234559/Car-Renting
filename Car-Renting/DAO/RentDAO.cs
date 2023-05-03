using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class RentDAO : IBaseDAO<Rent>
    {
        public List<Rent> GetAllList()
        {
            List<Rent> list = new List<Rent>();
            return list;
        }

        public DataTable GetAllDataTable()
        {
            string sqlStr = string.Format("select Rents.RentId,Cars.CarName,Clients.Name,DateStart,DateEnd,State,DateDelayQuantity,Deposit,EstimatedCost,CanceleReason,Cars.CategoryName as CategoryName from Rents, Cars, Clients where Rents.CarId = Cars.CarId and Rents.ClientId = Clients.ClientId ");
            return DbConnection.Instance.getData(sqlStr);
        }

        public Rent GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Rents");
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            DataRow[] result = dt.Select($"RentId = {id}");
            if (result.Length > 0)
            {
                DataRow row = result[0];
                int RentId = (int)row["RentId"];
                int CarId = (int)row["CarId"];
                int ClientId = (int)row["ClientId"];
                DateTime DateStart = (DateTime)row["dateStart"];
                DateTime DateEnd = (DateTime)row["dateEnd"];
                String State = row["state"].ToString();
                int tien_coc = (int)row["Deposit"];
                int EstimatedCost = (int)row["EstimatedCost"];
                string CancellationReason;
                if (row["CanceleReason"] == null)
                {
                    CancellationReason = "";
                }
                else
                {
                    CancellationReason = row["CanceleReason"].ToString();
                }
                int date =(int) row["DateDelayQuantity"];

                Rent Rent = new Rent
                (
                    RentId,
                    CarId,
                    ClientId,
                    DateStart,
                    DateEnd,
                    date,
                    State,
                    tien_coc,
                    EstimatedCost, CancellationReason
                );
                return Rent;
            }
            return null;

        }

        public int Insert(Rent entity)
        {
            string sqlStr = "INSERT INTO Rents (CarId, ClientId, DateStart, DateEnd, DateDelayQuantity, State, Deposit, EstimatedCost) VALUES (@CarId, @ClientId, @DateStart, @DateEnd, @DateDelayQuantity, @State, @Deposit, @EstimatedCost); SELECT SCOPE_IDENTITY();";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CarId", entity.CarId);
            parameters.Add("@ClientId", entity.ClientId);
            parameters.Add("@DateStart", entity.DateStart);
            parameters.Add("@DateEnd", entity.DateEnd);
            parameters.Add("@DateDelayQuantity", entity.DateDelayQuantity);
            parameters.Add("@State", entity.State);
            parameters.Add("@Deposit", entity.Deposit);
            parameters.Add("@EstimatedCost", entity.EstimatedCost);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
        }

        public int Update(Rent entity)
        {
            string sqlStr = "UPDATE Rents SET CarId = @CarId, ClientId = @ClientId, DateStart = @DateStart, DateEnd = @DateEnd, DateDelayQuantity = @DateDelayQuantity, State = @State, Deposit = @Deposit, EstimatedCost = @EstimatedCost WHERE RentId = @RentId";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CarId", entity.CarId);
            parameters.Add("@ClientId", entity.ClientId);
            parameters.Add("@DateStart", entity.DateStart);
            parameters.Add("@DateEnd", entity.DateEnd);
            parameters.Add("@DateDelayQuantity", entity.DateDelayQuantity);
            parameters.Add("@State", entity.State);
            parameters.Add("@Deposit", entity.Deposit);
            parameters.Add("@EstimatedCost", entity.EstimatedCost);
            parameters.Add("@RentId", entity.RentId);

            return DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);
        }

        public int Delete(Rent entity)
        {
            throw new NotImplementedException();
        }
    }
}
