using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
     class Account
    {
        public int AccID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IdUser { get; set; }

        public Account() { }

        public Account(int accID, string email, string password, string idUser)
        {
            AccID=accID;
            Email=email;
            Password=password;
            IdUser=idUser;
        }
    }
}
