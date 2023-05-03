using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }

        public string License { get; set; }
        public Client() { }

        public Client(int clientId, string name, string phone, string cCCD, string email, string license)
        {
            ClientId=clientId;
            Name=name;
            Phone=phone;
            CCCD=cCCD;
            Email=email;
            License=license;
        }
        public Client( string name, string phone, string cCCD, string email, string license)
        {
            Name=name;
            Phone=phone;
            CCCD=cCCD;
            Email=email;
            License=license;
        }
    }
}
