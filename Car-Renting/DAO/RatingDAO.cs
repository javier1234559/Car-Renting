using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class RatingDAO : BaseDAO<Rating>
    {
        //--------------- Override Methods ---------------- 
        public override int Delete(Rating entity)
        {
            string sqlStr = string.Format("DELETE FROM Rating WHERE RatingId = {0}", entity.RatingId);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

        public override DataTable GetAllDataTable()
        {
            string sqlStr = "SELECT * FROM Rating";
            return DbConnection.Instance.getData(sqlStr);
        }

        public override Rating GetById(int id)
        {
            string sqlStr = string.Format("SELECT * FROM Rating WHERE RatingId = {0}", id);
            DataTable dt = DbConnection.Instance.getData(sqlStr);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Rating rating = new Rating
                {
                    RatingId = (int)row["RatingId"],
                    RentId = (int)row["RentId"],
                    CarId = (int)row["CarId"],
                    RatingValue = (int)row["RatingValue"],
                    FeedBack = row["FeedBack"].ToString(),
                    ClientId = (int)row["ClientId"]
                };
                return rating;
            }
            return null;
        }

        public override int Insert(Rating entity)
        {
            string sqlStr = "INSERT INTO Rating (RentId, CarId, RatingValue, FeedBack, ClientId) VALUES (@RentId, @CarId, @RatingValue, @FeedBack, @ClientId); SELECT SCOPE_IDENTITY()";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@RentId", entity.RentId);
            parameters.Add("@CarId", entity.CarId);
            parameters.Add("@RatingValue", entity.RatingValue);
            parameters.Add("@FeedBack", entity.FeedBack);
            parameters.Add("@ClientId", entity.ClientId);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
        }

        public override int Update(Rating entity)
        {
            string sqlStr = "UPDATE Rating SET RentId = @RentId, CarId = @CarId, RatingValue = @RatingValue, FeedBack = @FeedBack, ClientId = @ClientId WHERE RatingId = @RatingId";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@RentId", entity.RentId);
            parameters.Add("@CarId", entity.CarId);
            parameters.Add("@RatingValue", entity.RatingValue);
            parameters.Add("@FeedBack", entity.FeedBack);
            parameters.Add("@ClientId", entity.ClientId);
            parameters.Add("@RatingId", entity.RatingId);

            return DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);
        }
    }

}
