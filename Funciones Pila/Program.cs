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
                Console.WriteLine("3.IsFull");
                Console.WriteLine("4.IsEmpty");
                Console.WriteLine("5.Mostrar");
                Console.WriteLine("6.peek");
                Console.WriteLine("7.Salir");
                Console.Write("Ingrese una Opcion: ");
                op = short.Parse(Console.ReadLine());
                switch (op)
                
                {
                    case 1:
                        lista.Push();
                        Console.Clear();
                        break;
                    case 2:
                        lista.pop();
                        Console.Clear();

                        break;
                    case 3:
                        lista.isFull();
                        Console.Clear();

                        break;
                    case 4:
                        lista.isEmpty();
                        Console.Clear();

                        break;
                    case 5:
                        lista.Mostrar();

                        break;
                    case 6:
                        lista.peek();
                        Console.Clear();
                        break;
                   case 7:
                        Console.WriteLine("Fin de la aplicacion");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opcion no Valida..");
                        break;
                }

            } while (op != 7);

        }
    }
}
