using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnCasa
{
    class Circulo: Operacion
    {
        private double r;
        public Circulo(double x)
        {
            r = x;
        }
        public override double area()
        {
            Console.WriteLine(" Area del circulo :");
            return (r * r * 3.1416);
        }
    }
}
