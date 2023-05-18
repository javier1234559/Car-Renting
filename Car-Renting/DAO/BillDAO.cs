using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class BillDAO : BaseDAO<Bill>
    {
        //--------------- Extends Methods ---------------- 
        public DataTable GetFullDataBill()
        {
            string sqlQuery = "SELECT B.*, R.DateStart, R.DateEnd, R.Deposit, RT.RatingValue, RT.FeedBack\r\nFROM Bills B\r\nJOIN Rents R ON B.RentId = R.RentId\r\nLEFT JOIN Rating RT ON R.RentId = RT.RentId";
            return DbConnection.Instance.getData(sqlQuery);
        }

        public DataTable SearchFullDataBill(string keyword)
        {
            string sqlQuery = "SELECT B.*,C.CarName , R.DateStart, R.DateEnd, R.Deposit, RT.RatingValue, RT.FeedBack " +
                              "FROM Bills B " +
                              "JOIN Rents R ON B.RentId = R.RentId " +
                              "LEFT JOIN Rating RT ON R.RentId = RT.RentId " +
                              "JOIN Cars C ON R.CarId = C.CarId " +
                              "JOIN Clients CL ON R.ClientId = CL.ClientId " +
                              "WHERE C.CarName LIKE '%" + keyword + "%' OR CL.Name LIKE '%" + keyword + "%'";
            return DbConnection.Instance.getData(sqlQuery);
        }

        public Dictionary<string, int> GetDataBestSeller(DateTime start, DateTime end)
        {
            string sqlQuery = $"SELECT Cars.CarName, COUNT(*) AS CarCount " +
                              "FROM Cars " +
                              "INNER JOIN Rents ON Cars.CarId = Rents.CarId " +
                              "INNER JOIN Bills ON Rents.RentId = Bills.RentId " +
                              $"WHERE Bills.CreateDate BETWEEN '{start.ToString("yyyy-MM-dd")}' AND '{end.ToString("yyyy-MM-dd")}' " +
                              "GROUP BY Cars.CarName";

            Dictionary<string, int> carCountByBill = new Dictionary<string, int>();

            DataTable dt = DbConnection.Instance.getData(sqlQuery);

            foreach (DataRow row in dt.Rows)
            {
                string carName = row["CarName"].ToString();
                int carCount = Convert.ToInt32(row["CarCount"]);

                carCountByBill.Add(carName, carCount);
            }

            return carCountByBill;
        }

        public Dictionary<string, int> GetDataDamaged(DateTime start, DateTime end)
        {
            string sqlQuery = "SELECT Cars.CarName, COUNT(*) AS CarCount " +
                              "FROM Cars " +
                              "INNER JOIN Rents ON Cars.CarId = Rents.CarId " +
                              "INNER JOIN Bills ON Rents.RentId = Bills.RentId " +
                              "WHERE Bills.CreateDate BETWEEN '" + start.ToString("yyyy-MM-dd") + "' AND '" + end.ToString("yyyy-MM-dd") + "' " +
                              "AND Bills.Compensation > 0 " +
                              "GROUP BY Cars.CarName";

            Dictionary<string, int> carCountByBill = new Dictionary<string, int>();

            DataTable dt = DbConnection.Instance.getData(sqlQuery);

            foreach (DataRow row in dt.Rows)
            {
                string carName = row["CarName"].ToString();
                int carCount = Convert.ToInt32(row["CarCount"]);

                carCountByBill.Add(carName, carCount);
            }

            return carCountByBill;
        }

        public Dictionary<string, int> GetDataRating()
        {
            string sqlQuery = "SELECT Cars.CarName, AVG(CAST(RT.RatingValue AS float)) AS AvgRatingValue " +
                              "FROM Cars " +
                              "INNER JOIN Rents ON Cars.CarId = Rents.CarId " +
                              "LEFT JOIN Rating RT ON Rents.RentId = RT.RentId " +
                              "GROUP BY Cars.CarName";

            Dictionary<string, double> avgRatingByCar = new Dictionary<string, double>();

            DataTable dt = DbConnection.Instance.getData(sqlQuery);

            foreach (DataRow row in dt.Rows)
            {
                string carName = row["CarName"].ToString();
                double avgRatingValue = 0.0;
                if (row["AvgRatingValue"] != DBNull.Value)
                {
                    avgRatingValue = Convert.ToDouble(row["AvgRatingValue"]);
                }

                avgRatingByCar.Add(carName, avgRatingValue);
            }

            Dictionary<string, int> avgRatingByCarInt = avgRatingByCar.ToDictionary(
                pair => pair.Key,
                pair => Convert.ToInt32(pair.Value)
            );

            return avgRatingByCarInt;
        }

        //--------------- Override Methods ---------------- 

        public override Bill GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Bills WHERE BillId={0}", id);
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Bill bill = new Bill
                {
                    BillId = (int)row["BillId"],
                    RentId = (int)row["RentId"],
                    IdUser = (int)row["IdUser"],
                    TotalCost = (decimal)row["TotalCost"],
                    CreateDate = (DateTime)row["CreateDate"],
                    CompensationName = row["CompensationName"].ToString(),
                    Compensation = (int)row["Compensation"],
                    CompensationDescript = row["CompensationDescript"].ToString(),
                    DiscountCode = row["DiscountCode"].ToString()
                };
                return bill;
            }
            return null;
        }

        public override DataTable GetAllDataTable()
        {
            string sqlStr = string.Format("SELECT * FROM Bills");
            return DbConnection.Instance.getData(sqlStr);
        }

        public override int Insert(Bill entity)
        {
            string sqlStr = @"INSERT INTO Bills (RentId, IdUser, TotalCost, CreateDate, CompensationName, Compensation, CompensationDescript, DiscountCode) 
                      VALUES (@RentId, @IdUser, @TotalCost, @CreateDate, @CompensationName, @Compensation, @CompensationDescript, @DiscountCode);
                      SELECT SCOPE_IDENTITY()";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@RentId", entity.RentId);
            parameters.Add("@IdUser", entity.IdUser);
            parameters.Add("@TotalCost", entity.TotalCost);
            parameters.Add("@CreateDate", entity.CreateDate);
            parameters.Add("@CompensationName", entity.CompensationName);
            parameters.Add("@Compensation", entity.Compensation);
            parameters.Add("@CompensationDescript", entity.CompensationDescript);
            parameters.Add("@DiscountCode", entity.DiscountCode);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
        }

        public override int Update(Bill entity)
        {
            string sqlStr = @"UPDATE Bills SET RentId = @RentId, IdUser = @IdUser, TotalCost = @TotalCost, 
                      CreateDate = @CreateDate, CompensationName = @CompensationName, Compensation = @Compensation, 
                      CompensationDescript = @CompensationDescript, DiscountCode = @DiscountCode WHERE BillId = @BillId";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@RentId", entity.RentId);
            parameters.Add("@IdUser", entity.IdUser);
            parameters.Add("@TotalCost", entity.TotalCost);
            parameters.Add("@CreateDate", entity.CreateDate);
            parameters.Add("@CompensationName", entity.CompensationName);
            parameters.Add("@Compensation", entity.Compensation);
            parameters.Add("@CompensationDescript", entity.CompensationDescript);
            parameters.Add("@DiscountCode", entity.DiscountCode);
            parameters.Add("@BillId", entity.BillId);

            return DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);
        }

        public override int Delete(Bill entity)
        {
            throw new NotImplementedException();
        }
    }
}
