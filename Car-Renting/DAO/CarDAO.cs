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
                    Description = row["Description"].ToString(),
                    ImageCar = row["ImageCar"].ToString()
                };
                return car;
            }
            return null;
        }

        public int Insert(Car entity)
        {
            string sqlStr = "";
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        public int Delete(Car entity)
        {
            string sqlStr = string.Format("delete from Cars where CarId = '{0}'", entity.CarId);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        public int Update(Car entity)
        {
            string sqlStr = "";
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }
    }
}
