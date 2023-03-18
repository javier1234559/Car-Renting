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
        public int Phone { get; set; }
        public int CCCD { get; set; }
        public string Email { get; set; }

        public Client() { }

        public Client(int clientId, string name, int phone, int cCCD, string email)
        {
            ClientId=clientId;
            Name=name;
            Phone=phone;
            CCCD=cCCD;
            Email=email;
        }
    }
}
