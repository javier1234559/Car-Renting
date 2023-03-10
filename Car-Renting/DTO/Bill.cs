using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class Bill
    {
        public int BillId { get; set; }
        public int RentId { get; set; }
        public int IdUser { get; set; }
        public int TotalCost { get; set; }
        public DateTime CreateDate { get; set; }

        public Bill() { }

        public Bill(int billId, int rentId, int idUser, int totalCost, DateTime createDate)
        {
            BillId=billId;
            RentId=rentId;
            IdUser=idUser;
            TotalCost=totalCost;
            CreateDate=createDate;
        }
    }
}
