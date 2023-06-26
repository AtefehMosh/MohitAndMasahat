using System;
using System.Collections.Generic;
using System.Text;

namespace MohitAndMasahat
{
    class rectangle
    {
        private double tool;
        private double arz;
        

        public double Tool
        {
            get { return tool; }
            set
            {
                if (value > 0)
                    tool = value;

            }
        }
        public double Arz
        {
            get { return arz; }
            set
            {
                if (value > 0)
                    arz = value;

            }
        }
       

        public rectangle() { }
        public rectangle(double input1, double input2)
        {
            Tool = input1;
            Arz = input2;
           

        }
        public double mohet()
        {
            return (tool*arz)/2;
        }
        public double masahat()
        {
            return tool*arz;
        }
    }
}

