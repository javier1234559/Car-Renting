using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class Rent
    {
        public int RentId { get; set; }
        public int CarId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd  { get; set; }
        public string State { get; set; }

        public Rent() { }

        public Rent(int rentId, int carId, int clientId, DateTime dateStart, DateTime dateEnd, string state)
        {
            RentId=rentId;
            CarId=carId;
            ClientId=clientId;
            DateStart=dateStart;
            DateEnd=dateEnd;
            State=state;
        }
    }
}
