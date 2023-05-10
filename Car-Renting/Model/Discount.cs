using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class Discount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal DiscountPercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public Discount () { }

        public Discount(int id, string code, decimal discountPercent, DateTime startDate, DateTime endDate, int quantity, DateTime createdDate, string createdBy)
        {
            Id=id;
            Code=code;
            DiscountPercent=discountPercent;
            StartDate=startDate;
            EndDate=endDate;
            Quantity=quantity;
            CreatedDate=createdDate;
            CreatedBy=createdBy;
        }


    }

}
