using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
     public class User
    {
        
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int TotalRevenue { get; set; }

        public User() { }   

        public User(int idUser, string name, string phone, string address, int totalRevenue)
        {
            IdUser=idUser;
            Name=name;
            Phone=phone;
            Address=address;
            TotalRevenue=totalRevenue;
        }
        public User( string name, string phone, string address, int totalRevenue)
        {
            Name=name;
            Phone=phone;
            Address=address;
            TotalRevenue=totalRevenue;
        }
    }
}
