using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka2
{
    class User
    {
        string login = "";
        string name = "";
        string surname = "";
        public DateTime date = new (2022, 09, 14);
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return name; }
            set { name = value; }
        }

    }
}
