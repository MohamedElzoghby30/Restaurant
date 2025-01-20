using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    internal class Food <S>
    {
        private S name;
        private S number;
        private S adress;

       
        public S Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public S Number
        {
            get { return number; }
            set { number = value; }
        }
        public S Adress
        {
            get { return adress; }
            set
            { adress = value; }
        }

     

    }
}
