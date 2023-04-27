using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CategoryName { get; set; }
        public string Brand { get; set; }
        public int Seats { get; set; }
        public int PricePerDay { get; set; }
        public string Description { get; set; }
        public string ImageCar { get; set; }

        public Car() { }

        public Car(int carId, string carName, string categoryName, string brand, int seats, int pricePerDay, string description, string imageCar)
        {
            CarId=carId;
            CarName=carName;
            CategoryName=categoryName;
            Brand=brand;
            Seats=seats;
            PricePerDay=pricePerDay;
            Description=description;
            ImageCar=imageCar;
        }

        public Car( string carName, string categoryName, string brand, int seats, int pricePerDay, string description, string imageCar)
        {
            CarName=carName;
            CategoryName=categoryName;
            Brand=brand;
            Seats=seats;
            PricePerDay=pricePerDay;
            Description=description;
            ImageCar=imageCar;
        }




    }
}
