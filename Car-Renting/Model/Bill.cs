using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class Bill
    {
        public int BillId { get; set; }
        public int RentId { get; set; }
        public int IdUser { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime CreateDate { get; set; }
        public string CompensationName { get; set; }
        public int Compensation { get; set; }
        public string CompensationDescript { get; set; }
        public string DiscountCode { get; set; } = "";

        public Bill() { }


    }
}
