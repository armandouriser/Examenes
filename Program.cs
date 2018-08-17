using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string aString = "";
            double b = 0;
            string bString = "";

            Console.WriteLine("introduce un numero ");
            aString = Console.ReadLine();
            a = Convert.ToInt16(aString);


            Console.WriteLine("introduce  otro numero");
            bString = Console.ReadLine();
            b = Convert.ToDouble(bString);

            

            Operaciones op = new Operaciones();
            op.setA(a);
            op.setB(b);

            Console.WriteLine("aplicando la suma = {0} ", op.getSuma());
            Console.WriteLine("aplicando la division = {0} ", op.getDiv());
            Console.ReadKey();
        }
    }
}
