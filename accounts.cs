using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek_UI
{
    internal class account
    {
        public string personalnumber { get; set; }
        public string password { get; set; }

        public account(string accountpersonalnumber, string accountpassword)
        {
            personalnumber = accountpersonalnumber;
            password = accountpassword;

        }
    }
}
