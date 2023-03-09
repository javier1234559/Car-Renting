using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CategoryId { get; set; }

        public string Brand { get; set; }

        public int Seats { get; set; }

        public int PricePerDay { get; set; }

        public string Description { get; set; }

        public Car() { }

        public Car(int carId, string carName, int categoryId, string brand, int seats, int pricePerDay, string description)
        {
            CarId=carId;
            CarName=carName;
            CategoryId=categoryId;
            Brand=brand;
            Seats=seats;
            PricePerDay=pricePerDay;
            Description=description;
        }
    }
}
