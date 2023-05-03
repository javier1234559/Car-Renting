using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    class Rating
    {
        public int RatingId { get; set; }
        public int RentId { get; set; }
        public int CarId { get; set; }
        public int RatingValue { get; set; }
        public string Feedback { get; set; }
        public int ClientId { get; set; }

        //
        public Rent Rent { get; set; }
        public Car Car { get; set; }
        public Client Client { get; set; }

        public Rating() { }

        public Rating(int ratingId, int rentId, int carId, int ratingValue, string feedback, int clientId)
        {
            RatingId=ratingId;
            RentId=rentId;
            CarId=carId;
            RatingValue=ratingValue;
            Feedback=feedback;
            ClientId=clientId;
        }
    }
}
