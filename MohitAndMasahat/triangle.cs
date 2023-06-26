using System;
using System.Collections.Generic;
using System.Text;

namespace MohitAndMasahat
{
    class triangle
    {
        private double a1;
        private double a2;
        private double a3;
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
        public double A2
        {
            get { return a2; }
            set
            {
                if (value > 0)
                    a2 = value;

            }
        }
        public double A3
        {
            get { return a3; }
            set
            {
                if (value > 0)
                    a3 = value;

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

        public triangle() { }
        public triangle(double input1, double input2, double input3, double input4)
        {
            A1 = input1;
            A2 = input2;
            A3 = input3;
            H = input4;

        }
        public double mohet ()
        {
            return a1 + a2 + a3;
        }
        public double masahat ()
        {
            return (a1*h)/2;
        }
    }

}
