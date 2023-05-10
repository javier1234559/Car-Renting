using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public static class Contraint
    {
        public static string STATE_PEDDING = "Pending";
        public static string STATE_RENTING = "Renting";
        public static string STATE_AVAILABLE = "Available";
        public static string STATE_WAITING = "Waiting";
        public static string STATE_CANCLED = "Canceled";

        public static string DISCOUNT_INVALIDCODE = "Invalid";
        public static string DISCOUNT_EXPIRED = "Expired";
        public static string DISCOUNT_VALID = "Valid";
        public static string DISCOUNT_NOQUANTITY = "NoQuantity";

    }
}
