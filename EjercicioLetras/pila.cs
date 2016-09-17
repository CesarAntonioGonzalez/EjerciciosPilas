using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLetras
{
    class pila
    
        {

        char[] cola = new char[10];
        int top = -1;
        char item;
        string otro;


        public bool isEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isFull()
        {
            if (top == cola.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int peek()
        {
            return cola[top];
        }
        public void Push()
        {
            while (top < 9)
            {
                Console.Write("Igrese: ");
                item = char.Parse(Console.ReadLine());
                top++;
                if (!isFull())
                {
                    cola[top] = item;
                }
                else
                {

                }
            }
        }
        public void pop()
        {
            if (!isEmpty())
            {
                cola[top] = ' ';
                top--;
            }
        }
        public void Mostrar()
        {
            string nuevo = "";
            string most = new string(cola);
            for (int i = most.Length - 1; i >=0;i--)
            {
                nuevo += most[i];
            }
            Console.WriteLine(nuevo);
        }
        

    }
}

