using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;//лічильник точок
        
        private double F1(double x) 
        {
            double den = Math.Pow(Math.Abs(x), 1.2) * Math.Sin(3 * x);
            if (Math.Abs(den) < 1e-7) return 0;
            return Math.Tan(Math.Pow((x + 3), 2)) / den;
        }
        private double F2(double x)
        {
            double den = Math.Pow(x, 2) + Math.Sin(7*x) - 1;
            if (Math.Abs(den) < 1e-7) return 0;
            return Math.Pow(x, 3) - 4 * x + 2;
        }
        private double F3(double x)
        {
            double den = Math.Tan(0.1*Math.PI*Math.Pow(x,2));
            if (Math.Abs(den) < 1e-7) return 0;
            return Math.Pow(Math.Cos(2*x+3), 2);
        }

        public void Tab(double xn=-1.7, double xk=45.3, double h=0.3, double a=10)
        {
            double x = xn;
            n = 0;
            while (x <= xk)
            {
                double y;
                if (x <= 0)
                    y = F1(x);
                else if (x > 0 && x <= a)
                    y = F2(x);
                else
                    y = F3(x);

                xy[n, 0] = x;
                xy[n, 1] = y;
                x += h;
                n++;
            }
        }
    }
}
