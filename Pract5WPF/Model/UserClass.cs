using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract5WPF.Model
{
    class UserClass
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

        public UserClass(string Name, string Password, double Balance)
        {
            this.Name = Name;
            this.Password = Password;
            this.Balance = Balance;
        }
    }
}
