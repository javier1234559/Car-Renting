using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public static class Session
    {
        public static Account LoginedAccount { get; set; }

        public static User Currentuser { get; set; }

        public static Car Currentcar { get; set; }

        public static Client Currentclient { get; set; }

        public static Rent Currentrent { get; set; }

        public static Bill CurrentBill { get; set; }

        public static Account Currentaccount { get; set;}

        public static User CurrentuserAtDashboard { get; set; }

        public static Account CurrentaccountAtDashboard { get; set; }

        public static Rent CurrentrentCanceled { get; set; }
    }
}
