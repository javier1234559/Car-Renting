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
        public int CategoryId { get; set; }

        public string Brand { get; set; }

        public string ImageCar { get; set; }

        public int PricePerDay { get; set; }

        public string Description { get; set; }

        public Car() { }

        public Car(int carId, string carName, int categoryId, string brand, string imageCar, int pricePerDay, string description)
        {
            CarId=carId;
            CarName=carName;
            CategoryId=categoryId;
            Brand=brand;
            ImageCar=imageCar;
            PricePerDay=pricePerDay;
            Description=description;
        }
    }
}
