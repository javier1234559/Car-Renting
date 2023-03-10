using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class CarDAO
    {
        public DataTable getListCar()
        {
            string sqlStr = string.Format("SELECT * FROM Cars");
            return DbConnection.Instance.getData(sqlStr);

        }

        public int Them(Car car)
        {
            string sqlStr = string.Format("INSERT INTO Cars (CarId, CarName, CategoryId, Brand, ImageCar, PricePerDay, Description) VALUES ({0},{1},{2},{3},{4},{5},{6},{7})", car.CarId, car.CarName, car.CategoryId, car.Brand, car.ImageCar, car.PricePerDay, car.Description);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        //public int Sua(Car car)
        //{
        //    string sqlStr = string.Format("delete from Car where Ten = '{0}'", car.Name);
        //    return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        //}

        //public int Xoa(Car car)
        //{
        //    string sqlStr = string.Format("update Car set Diachi = '{0}' where Ten = '{1}'", car.Diachi, car.Name);
        //    return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        //}
    }
}
