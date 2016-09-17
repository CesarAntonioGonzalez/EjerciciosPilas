using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila lista=  new Pila();
            short op;

            do             
            {
                Console.WriteLine("\n Aplicacion Listas \n");
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop ");
                Console.WriteLine("3.Peek");
                Console.WriteLine("4.Salir");
                Console.Write("Ingrese una Opcion: ");
                op = short.Parse(Console.ReadLine());
                switch (op)
                
                {
                    case 1:
                        lista.Push();
                        lista.Mostrar();
                        break;
                    case 2:
                        lista.removesecond();
                        lista.Mostrar();

                        break;

                    case 3:
                        lista.peek();
                        break;
                   case 4:
                        Console.WriteLine("Fin de la aplicacion");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opcion no Valida..");
                        break;
                }

            } while (op != 4);

        }
    }
}
