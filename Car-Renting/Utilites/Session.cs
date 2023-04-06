using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public static class Session
    {
        public static User currentuser { get; set; }

        public static Car currentcar { get; set; }

        public static Client currentclient { get; set; }

        public static Rent currentrent { get; set; }

        public static Bill currentBill { get; set; }

        public static Account currentaccount { get; set;}

        public static User currentuserAtDashboard { get; set; }

        public static Account currentaccountAtDashboard { get; set; }

    }
}
