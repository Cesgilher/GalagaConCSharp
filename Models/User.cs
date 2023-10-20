using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_.Models
{
    public class User
    {
        private string name;
        private int phoneNumber;
        private string email;
        private string password;



        public User(string name, int phoneNumbre, string email, string password)
        {
            this.name = name;
            phoneNumber = phoneNumbre;
            this.email = email;
            this.password = password;
        }
        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }


    }
}
