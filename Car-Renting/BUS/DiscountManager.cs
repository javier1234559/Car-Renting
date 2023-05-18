using System;
using Car_Renting.DAO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class DiscountManager
    {
        private DiscountDAO _discountDAO;
        private BillDAO _billDAO;
        private RentDAO _rentDAO;

        public DiscountManager()
        {
            _discountDAO = new DiscountDAO();
            _billDAO = new BillDAO();
            _rentDAO = new RentDAO();
        }

        public int AddDiscount(Discount newDiscount)
        {
            string code = GenerateCode();
            newDiscount.Code = code;
            return _discountDAO.Insert(newDiscount);
        }

        public DataTable getAllDiscount()
        {
            DataTable dt = _discountDAO.GetAllDataTable();
            return dt;
        }

        public String CheckDiscount(string code)
        {
            Discount discount = _discountDAO.GetByDiscountCode(code);

            if (discount == null)
            {
                return Contraint.DISCOUNT_INVALIDCODE;
            }
            if (discount.StartDate > DateTime.Now || discount.EndDate < DateTime.Now)
            {
                return Contraint.DISCOUNT_EXPIRED;
            }
            if (discount.Quantity == 0)
            {
                return Contraint.DISCOUNT_NOQUANTITY;
            }
            return Contraint.DISCOUNT_VALID;
        }

        public Discount GetDiscountByCode(string code)
        {
            Discount discount = _discountDAO.GetByDiscountCode(code);
            return discount;
        }

        private string GenerateCode()
        {
            // Generate a unique code for the discount
            Random random = new Random();
            string code = "";
            do
            {
                code = random.Next(1000, 10000).ToString();
            } while (_discountDAO.GetByDiscountCode(code) != null);
            return code;
        }

        public decimal HandleDiscountForVip(int idCLient, decimal cost)
        {
            DataTable dt = _billDAO.GetAllDataTable();
            int count = 0;
            foreach (DataRow row in dt.Rows)
            {
                int rentId = Convert.ToInt32(row["RentId"]);
                Rent rent = _rentDAO.GetById(rentId);
                if (rent.ClientId == idCLient) count++;
            }
            if (count > 2)
                return cost * 0.9m; // apply a 10% discount
            else
                return cost;
        }

        public void DecreaseQuantityDiscount(Discount discount)
        {
            discount.Quantity -= discount.Quantity ;
            _discountDAO.Update(discount);
        }

    }

}
