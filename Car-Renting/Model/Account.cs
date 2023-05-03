using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
     public class Account
    {
        public int AccID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdUser { get; set; }

        public Account() { }

        public Account(int accID, string email, string password, int idUser)
        {
            AccID=accID;
            Email=email;
            Password=password;
            IdUser=idUser;
        }
        public Account(string email, string password, int idUser)
        {
            Email=email;
            Password=password;
            IdUser=idUser;
        }
    }
}
