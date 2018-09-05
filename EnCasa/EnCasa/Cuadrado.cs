using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnCasa
{
    class Cuadrado: Operacion
    {
        private double l;
        public Cuadrado(double x)
        {
            l = x;
        }
        public override double area()
        {
            Console.WriteLine(" Area del cuadrado :");
            return (l * l );
        }
    }
}
