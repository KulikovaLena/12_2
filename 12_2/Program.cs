using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vvedite znachenie koordonatu centra okrugnosti x0 ");
                double x0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vvedite znachenie koordonatu centra okrugnosti y0 ");
                double  y0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vvedite znachenie radiusa r ");
                double  R = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vvedite koordinatu tochki x ");
                double  x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Vvedite koordinatu tochki y ");
                double  y = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(x0, y0, R, x, y);
                circle.L();
                circle.S();
                circle.XY();
            }
            catch
            {
                Console.WriteLine("Oshibka! Vhodnay stroka imela nevernii format");
            }
            Console.ReadKey();
        }
    }


    public class Circle
    {
        public double X0 { get; set; }
        public double Y0 { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        double r;

        public double R
        {
            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else
                {
                    Console.WriteLine("Radius dolgen bit' >0");
                }
            }
            get
            {
                return r;
            }
        }
        
        public Circle(double x0, double y0, double r, double x, double y)
        {
            X0 = x0;
            Y0 = y0;
            R = r;
            X = x;
            Y = y;
        }
        public void L()
        {
            Console.WriteLine("Dlina okrugnosti {0:0.00}", 2 * Math.PI * r);
        }
        public void S()
        {
            Console.WriteLine("Ploshad' kruga {0:0.00}", Math.PI * r * r);
        }
        public void XY()
        {
            if (r == Math.Sqrt((X - X0) * (X - X0) + (Y - Y0) * (Y - Y0)))
            {
                Console.WriteLine("Tochka c koordinatani (x,y) prinadlegit okrugnosti");
            }
            else
            {
                Console.WriteLine("Tochka c koordinatani (x,y) ne prinadlegit okrugnosti");
            }
        }
    }
}
