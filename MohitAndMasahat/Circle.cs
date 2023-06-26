using System;
using System.Collections.Generic;
using System.Text;

namespace MohitAndMasahat
{
    class Circle
    {
        double pi = 3.14;
        private double r;
        
        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
            }
        }
        public Circle() { }
        public Circle(double rr)
        {
            R = rr;
        }
        public double mohit()
        {
            return 2 * r * pi;
        }
        public double masahat()
        {
            return Math.Pow(r,2)*pi;
        }
    }

}
