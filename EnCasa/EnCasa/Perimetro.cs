using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnCasa
{
   public class Perimetro
    {
        /*double P;*/
        public Perimetro(double p)
        {
            P = p;
        }
        public static double operator+(Perimetro x, Perimetro y)
        {
            return 2*x.P + 2*y.P;
        }
        public double P { get; set; }
    }
}
