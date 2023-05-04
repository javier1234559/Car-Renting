using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting
{
    class CarDAO : IBaseDAO <Car>
    {
        public DataTable GetAllDataTable()
        {
            var sql = @"SELECT * from Cars;";

            return DbConnection.Instance.getData(sql);
        }
        public DataTable GetAllDataTableAvaiable()
        {
             string sql = @"SELECT * FROM Cars 
                            WHERE CarId NOT IN (
                              SELECT CarId FROM Rents WHERE State <> 'Available'
                            )
                            ";

            return DbConnection.Instance.getData(sql);
        }


        public Car GetById(int id)
        {
            string sqlStr = $"SELECT * FROM Cars WHERE CarId = {id}";
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Car car = new Car
                {
                    CarId = (int)row["CarId"],
                    CarName = row["CarName"].ToString(),
                    CategoryName = row["CategoryName"].ToString(),
                    Brand = row["Brand"].ToString(),
                    Seats = (int)row["Seats"],
                    PricePerDay = (int)row["PricePerDay"],
                    NumberPlate = row["NumberPlate"].ToString(),
                    Description = row["Description"].ToString(),
                    ImageCar = row["ImageCar"].ToString()
                };
                return car;
            }
            return null;
        }


        public Car GetByImageName(string imageName)
        {
            string sqlStr = $"SELECT * FROM Cars WHERE ImageCar = '{imageName}'";
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Car car = new Car
                {
                    CarId = (int)row["CarId"],
                    CarName = row["CarName"].ToString(),
                    CategoryName = row["CategoryName"].ToString(),
                    Brand = row["Brand"].ToString(),
                    Seats = (int)row["Seats"],
                    PricePerDay = (int)row["PricePerDay"],
                    NumberPlate = row["NumberPlate"].ToString(),
                    Description = row["Description"].ToString(),
                    ImageCar = row["ImageCar"].ToString()
                };
                return car;
            }
            return null;
        }


        public int Insert(Car entity)
        {
            string sqlStr = string.Format("INSERT INTO Cars (CarName, CategoryName, Brand, Seats, PricePerDay, NumberPlate, Description, ImageCar) VALUES (@CarName, @CategoryName, @Brand, @Seats, @PricePerDay, @NumberPlate, @Description, @ImageCar); SELECT SCOPE_IDENTITY()");

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CarName", entity.CarName);
            parameters.Add("@CategoryName", entity.CategoryName);
            parameters.Add("@Brand", entity.Brand);
            parameters.Add("@Seats", entity.Seats);
            parameters.Add("@PricePerDay", entity.PricePerDay);
            parameters.Add("@NumberPlate", entity.NumberPlate);
            parameters.Add("@Description", entity.Description);
            parameters.Add("@ImageCar", entity.ImageCar);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
        }



        public int Delete(Car entity)
        {
            string sqlStr = string.Format("delete from Cars where CarId = '{0}'", entity.CarId);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        public int Update(Car entity)
        {
            string sqlStr = "UPDATE Cars SET CarName = @CarName, CategoryName = @CategoryName, Brand = @Brand, Seats = @Seats, PricePerDay = @PricePerDay, NumberPlate = @NumberPlate, Description = @Description, ImageCar = @ImageCar WHERE CarId = @CarId";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CarName", entity.CarName);
            parameters.Add("@CategoryName", entity.CategoryName);
            parameters.Add("@Brand", entity.Brand);
            parameters.Add("@Seats", entity.Seats);
            parameters.Add("@PricePerDay", entity.PricePerDay);
            parameters.Add("@NumberPlate", entity.NumberPlate);
            parameters.Add("@Description", entity.Description);
            parameters.Add("@ImageCar", entity.ImageCar);
            parameters.Add("@CarId", entity.CarId);

            return DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);
        }


    }
}
