using System;
using System.Collections.Generic;
using System.Text;

namespace MohitAndMasahat
{
    class hexagon
    {
        private double a1;
       
        private double h;

        public double A1
        {
            get { return a1; }
            set
            {
                if (value > 0)
                    a1 = value;

            }
        }
       
        public double H
        {
            get { return h; }
            set
            {
                if (value > 0)
                    h = value;

            }
        }

        public hexagon() { }
        public hexagon(double input1,double hh)
        {
            A1 = input1;
          
            H = hh;

        }
        public double mohet()
        {
            return a1 * 6;
        }
        public double masahat()
        {
            return ( mohet() * h) / 2;
        }
    }
}
