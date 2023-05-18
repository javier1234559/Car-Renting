using Car_Renting.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.IO.Util.IntHashtable;

namespace Car_Renting
{
    public class DiscountDAO : BaseDAO<Discount>
    {
        //--------------- Extends Methods ---------------- 
        public Discount GetByDiscountCode(string code)
        {
            string sqlStr = string.Format("SELECT * FROM Discount WHERE Code = '{0}'", code);
            DataTable dataTable = DbConnection.Instance.getData(sqlStr);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                DataRow row = dataTable.Rows[0];
                return new Discount
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Code = Convert.ToString(row["Code"]),
                    DiscountPercent = Convert.ToDecimal(row["DiscountPercent"]),
                    StartDate = Convert.ToDateTime(row["StartDate"]),
                    EndDate = Convert.ToDateTime(row["EndDate"]),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    CreatedDate = Convert.ToDateTime(row["CreatedDate"]),
                    CreatedBy = Convert.ToString(row["CreatedBy"])
                };
            }
        }

        //--------------- Override Methods ---------------- 

        public override DataTable GetAllDataTable()
        {
            string sqlStr = "SELECT * FROM Discount";
            return DbConnection.Instance.getData(sqlStr);
        }

        public override Discount GetById(int id)
        {
            string sqlStr = "SELECT * FROM Discount WHERE Id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Id", id);
            DataTable dataTable = DbConnection.Instance.getData(sqlStr);
            if (dataTable.Rows.Count > 0)
            {
                Discount discount = new Discount();
                discount.Id = Convert.ToInt32(dataTable.Rows[0]["Id"]);
                discount.Code = dataTable.Rows[0]["Code"].ToString();
                discount.DiscountPercent = Convert.ToDecimal(dataTable.Rows[0]["DiscountPercent"]);
                discount.StartDate = Convert.ToDateTime(dataTable.Rows[0]["StartDate"]);
                discount.EndDate = Convert.ToDateTime(dataTable.Rows[0]["EndDate"]);
                discount.Quantity = Convert.ToInt32(dataTable.Rows[0]["Quantity"]);
                discount.CreatedDate = Convert.ToDateTime(dataTable.Rows[0]["CreatedDate"]);
                discount.CreatedBy = dataTable.Rows[0]["CreatedBy"].ToString();
                return discount;
            }
            else
            {
                return null;
            }
        }

        public override int Insert(Discount entity)
        {
            string sqlStr = @"INSERT INTO Discount(Code, DiscountPercent, StartDate, EndDate, Quantity, CreatedDate, CreatedBy) 
                          VALUES(@Code, @DiscountPercent, @StartDate, @EndDate, @Quantity, @CreatedDate, @CreatedBy);
                          SELECT CAST(scope_identity() AS int)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Code", entity.Code);
            parameters.Add("@DiscountPercent", entity.DiscountPercent);
            parameters.Add("@StartDate", entity.StartDate);
            parameters.Add("@EndDate", entity.EndDate);
            parameters.Add("@Quantity", entity.Quantity);
            parameters.Add("@CreatedDate", entity.CreatedDate);
            parameters.Add("@CreatedBy", entity.CreatedBy);

            int newId = (int)DbConnection.Instance.executeInsertQuery(sqlStr, parameters);

            return newId;
        }

        public override int Update(Discount entity)
        {
            string sqlStr = @"UPDATE Discount 
                          SET Code = @Code, DiscountPercent = @DiscountPercent, StartDate = @StartDate, EndDate = @EndDate,
                              Quantity = @Quantity, CreatedDate = @CreatedDate, CreatedBy = @CreatedBy 
                          WHERE Id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Code", entity.Code);
            parameters.Add("@DiscountPercent", entity.DiscountPercent);
            parameters.Add("@StartDate", entity.StartDate);
            parameters.Add("@EndDate", entity.EndDate);
            parameters.Add("@Quantity", entity.Quantity);
            parameters.Add("@CreatedDate", entity.CreatedDate);
            parameters.Add("@CreatedBy", entity.CreatedBy);
            parameters.Add("@Id", entity.Id);
            return DbConnection.Instance.executeUpdateQuery(sqlStr, parameters);
        }
        
        public override int Delete(Discount entity)
        {
            string sqlStr = string.Format("DELETE FROM Discount WHERE Id = '{0}'", entity.Id);
            return DbConnection.Instance.ExecuteNonQuery(sqlStr);
        }

    }
}
