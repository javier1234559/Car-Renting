using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int RentId { get; set; }
        public int CarId { get; set; }
        public int RatingValue { get; set; }
        public string FeedBack { get; set; }
        public int ClientId { get; set; }

        // Constructor
        public Rating( int rentId, int carId, int ratingValue, string feedBack, int clientId)
        {
            RentId = rentId;
            CarId = carId;
            RatingValue = ratingValue;
            FeedBack = feedBack;
            ClientId = clientId;
        }

        public Rating() { }

    }

}
