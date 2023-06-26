using System;
using System.Collections.Generic;
using System.Text;

namespace MohitAndMasahat
{
    class square
    {
        private int a;

        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
            }
        }

        public square() { }

        public square(int x1)
        {
            A = x1;
        }

        public double mohite()
        {
            return a * 4;
        }
        public double masahat()
        {
            return Math.Pow(a,2);
        }

    }
       


}
