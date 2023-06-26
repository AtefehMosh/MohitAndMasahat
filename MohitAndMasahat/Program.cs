using System;

namespace MohitAndMasahat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pelse Enter the polygon number to calculate piremeter and area:\n\n1:circle 2:square 3:rectangle 4:triangle 5:hexagon 6:trapizius ");
            int numberr = Convert.ToInt32(Console.ReadLine());

            if (numberr == 1)
            {
                Console.WriteLine(" Enter the redius:");
                double r = Convert.ToDouble(Console.ReadLine());
                Circle C1 = new Circle(r);
                Console.WriteLine("mohit=" + C1.mohit() + "masahat=" + C1.masahat());
            }
            else if (numberr == 2)
            {
                Console.WriteLine(" Enter the Side of square:");
                int s = Convert.ToInt32(Console.ReadLine());
                square S1 = new square(s);
                Console.WriteLine("mohit=" + S1.mohite() + "masahat=" + S1.masahat());
            }
            else if (numberr == 3)
            {
                Console.WriteLine(" Enter the Sides of rectangel:");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                rectangle R1 = new rectangle(x, y);
                Console.WriteLine("mohit=" + R1.mohet() + "masahat=" + R1.masahat());
            }
            else if (numberr == 4)
            {
                Console.WriteLine(" Enter the Sides of triangle And Height :");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());

                triangle T1 = new triangle(x, y, x, h);
                Console.WriteLine("mohit=" + T1.mohet() + "masahat=" + T1.masahat());
            }
            else if (numberr == 5)
            {
                Console.WriteLine(" Enter the Side of hexagon And Height :");
                double x = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());
                hexagon H1 = new hexagon(x, h);
                Console.WriteLine("mohit=" + H1.mohet() + "masahat=" + H1.masahat());

            }
            else if (numberr == 6)
            {
                Console.WriteLine(" Enter the Sides of trapeziud And Height :");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                double k = Convert.ToDouble(Console.ReadLine());
                double h = Convert.ToDouble(Console.ReadLine());


                Trapezius TT1 = new Trapezius(x, y, x,k, h);
                Console.WriteLine("mohit=" + TT1.mohet() + "masahat= " + TT1.masahat());
            }


        }
    }
}
