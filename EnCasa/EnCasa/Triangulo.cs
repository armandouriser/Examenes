using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnCasa
{
    class Triangulo: Operacion
    {
        private double b,a, s;
        public Triangulo(double x, double y)
        {
            b = x;
            a = y;
        }
        public override double area()
        {
            s = (b * a) / 2;
            Console.WriteLine(" Area del triangulo :");
            return (s);
        }
    }
}
