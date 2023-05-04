using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class Rent
    {
        public int RentId { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string DescriptionRent { get; set; }
        public int DateDelayQuantity { get; set; }
        public string State { get; set; }
        public int Deposit { get; set; }
        public string CancellationReason { get; set; }

      
        public Rent(int rentId, int carId, int clientId, DateTime dateStart, DateTime dateEnd, int dateDelayQuantity, string state,int deposit, string cancellationReason)
        {
            RentId=rentId;
            CarId=carId;
            ClientId=clientId;
            DateStart=dateStart;
            DateEnd=dateEnd;
            DateDelayQuantity=dateDelayQuantity;
            State=state;
            Deposit=deposit;
            CancellationReason=cancellationReason;
        }

        public Rent() { }

        public Rent(int carId, DateTime dateStart, DateTime dateEnd, int deposit , string descriptionRent)
        {
            CarId=carId;
            DateStart=dateStart;
            DateEnd=dateEnd;
            Deposit=deposit;
            DescriptionRent=descriptionRent;

        }
    }
}
