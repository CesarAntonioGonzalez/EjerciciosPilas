using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            pila lista = new pila();
            do
            {
                Console.WriteLine("1. Push Letra");
                Console.WriteLine("2. Pop Letra");
                Console.WriteLine("3. Salir");
                Console.Write("Escoga una opcion:  ");
                op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        lista.Push();
                        lista.Mostrar();
                        break;
                    case 2:
                        lista.pop();
                        lista.Mostrar();
                        break;
                    case 3:
                        Console.WriteLine("Esta saliendo del programa");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Intente de nuevo");
                        break;
                }
               

            } while (op != 3);
            
        }
    }
}
