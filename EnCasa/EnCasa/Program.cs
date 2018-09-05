using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            

        
                /*Figura ObjFiguras = new Figura();*/
                int menu;
                double a=0,b=0,c=0,f=0,g=0;



                Console.WriteLine("Seleciona la Figura \n1) Cuadrado\n2) Triangulo\n3) Circulo\n");
                menu = Convert.ToInt16(Console.ReadLine());

                switch (menu)
                {
                   
                    case 1:
                        Console.WriteLine("Escogiste cuadrado, dame el lado");
                        
                      Cuadrado Cua = new Cuadrado(  a = Convert.ToDouble(Console.ReadLine()));
                    double Cu = Cua.area();
                    Console.WriteLine(" {0}", Cu);
                    Perimetro X = new Perimetro(a);
                    Perimetro Y = new Perimetro(a);
                    double PT = X + Y;
                    Console.WriteLine("el perimetro del cuadrado es " + PT);
                    Console.ReadKey();
                        /*ObjFiguras.CalcularArea();*/
                        break;
                    case 2:
                        Console.WriteLine("Escogiste Triangulo, dame la base ");
                        
                    f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Escogiste Triangulo, dame la altura");
                    
                    g = Convert.ToDouble(Console.ReadLine());
                    Triangulo x = new Triangulo(f, g );

                    /*Triangulo y = new Triangulo(b = Convert.ToDouble(Console.ReadLine()));*/
                    double s = x.area();
                    Console.WriteLine(" {0}", s);
                   
                    Console.ReadKey();


                    /*ObjFiguras.CalcularArea();*/
                    break;
                    case 3:
                        Console.WriteLine("Escogiste Circulo, dame el radio");
                    c = Convert.ToDouble(Console.ReadLine());
                     Circulo  Cir = new Circulo(c);
                    double C = Cir.area();
                    Console.WriteLine(" {0}", C);
                    
                    Console.ReadKey();

                    /*ObjFiguras.CalcularArea();*/
                    break;

                default:
                    Console.WriteLine("opcion invalida-");
                    break;
                


                }
            Console.ReadLine();
            
         


            }
        }
    }
