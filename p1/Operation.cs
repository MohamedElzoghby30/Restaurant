using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    sealed internal class Operation : Interface1
    {
        public int sundaw(int nu)
        {
            int sum = 30;

            return nu * sum;
        }
        public int pizza(int nu)
        {
            int sum = 50;

            return nu * sum;
        }
        public int tog(int nump, int numsan)
        {
            int sump = 50, sumsan = 30;
            return (nump * sump) + (numsan * sumsan);
        }



    }

    internal class Interface1
    {
    }
}
