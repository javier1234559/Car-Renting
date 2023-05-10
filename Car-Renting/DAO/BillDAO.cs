using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class BillDAO : BaseDAO<Bill>
    {
        public override DataTable GetAllDataTable()
        {
            string sqlStr = string.Format("SELECT * FROM Bills");
            return DbConnection.Instance.getData(sqlStr);
        }

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
