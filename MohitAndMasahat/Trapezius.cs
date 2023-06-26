using System;
using System.Collections.Generic;
using System.Text;

namespace MohitAndMasahat
{
    class Trapezius
    {
        private double a1;//قائده بزرگ
        private double a2;//قائده کوچک
        private double a3;
        private double a4;
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
        public double A4
        {
            get { return a4; }
            set
            {
                if (value > 0)
                    a4 = value;

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

        public Trapezius() { }
        public Trapezius(double input1, double input2, double input3, double input4,double hh)
        {
            A1 = input1;
            A2 = input2;
            A3 = input3;
            A4 = input4;
            H = hh;

        }
        public double mohet()
        {
            return a1 + a2 + a3+a4;
        }
        public double masahat()
        {
            return a1 * a2 * (h / 2);
        }
    }
}
