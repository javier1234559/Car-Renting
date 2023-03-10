using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class CarDAO : IBaseDAO <Car>
    {
        public List<Car> GetAllList()
        {
            List<Car> list = new List<Car>();

            return list;
        }

        public DataTable GetAllDataTable()
        {
            string sqlStr = string.Format("SELECT * FROM Cars");
            return DbConnection.Instance.getData(sqlStr);
        }

        public Car GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Cars");
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            DataRow[] result = dt.Select($"CarId = {id}");
            if (result.Length > 0)
            {
                DataRow row = result[0];
                Car Car = new Car
                {
                    CarId = (int)row["CarId"],
                    CarName = row["CarName"].ToString(),
                    CategoryId = (int)row["CategoryId"],
                    Brand = row["Brand"].ToString(),
                    ImageCar  = row["ImageCar"].ToString(),
                    PricePerDay  = (int)row["PricePerDay"],
                    Description  = row["Description"].ToString(),    
                };
                return Car;
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
