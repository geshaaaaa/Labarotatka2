using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka2
{
    class Adress
    {

        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private string country = "";
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private int house ;
        public int House
        { get { return house; }
            set { house = value; }
        }
        private int apartament;
        public int Apartament
        { get { return apartament; } set { apartament = value; }
        }

       
    }
}
