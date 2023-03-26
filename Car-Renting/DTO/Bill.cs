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
        public int TotalCost { get; set; }
        public DateTime CreateDate { get; set; }
        public string CompensationName { get; set; }
        public int Compensation { get; set; }
        public string CompensationDescript { get; set; }

        public Bill() { }

        public Bill(int billId, int rentId, int idUser, int totalCost, DateTime createDate, string compensationName, int compensation, string compensationDescript)
        {
            BillId=billId;
            RentId=rentId;
            IdUser=idUser;
            TotalCost=totalCost;
            CreateDate=createDate;
            CompensationName=compensationName;
            Compensation=compensation;
            CompensationDescript=compensationDescript;
        }

    }
}
