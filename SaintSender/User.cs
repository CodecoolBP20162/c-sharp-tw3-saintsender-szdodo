using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class User
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public User(string EmailAddress, string Password)
        {
            this.EmailAddress = EmailAddress;
            this.Password = Password;
            UserName = EmailAddress.Substring(0, EmailAddress.Length - 10);
        }
    }
}
