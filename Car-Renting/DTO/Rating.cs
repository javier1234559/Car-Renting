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
        public int RatingValue { get; set; }
        public int FeedBack { get; set; }
        public int ClientId { get; set; }

        public Rating() { }

        public Rating(int ratingId, int rentId, int ratingValue, int feedBack, int clientId)
        {
            RatingId=ratingId;
            RentId=rentId;
            RatingValue=ratingValue;
            FeedBack=feedBack;
            ClientId=clientId;
        }
    }
}
