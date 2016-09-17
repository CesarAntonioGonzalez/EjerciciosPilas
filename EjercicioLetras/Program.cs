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
            
            pila lista = new pila();
            lista.Push();
            lista.Mostrar();
            Console.ReadLine();
            lista.pop();
            lista.Mostrar();
            Console.ReadLine();
            lista.pop();
            
        }
    }
}
