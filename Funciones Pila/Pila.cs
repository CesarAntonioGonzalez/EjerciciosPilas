using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_Pila
{
    class Pila
    {

        int[] cola = new int[10];
        int top = -1;
        int item = 0;
        int second = 1;
        int top2 = 9;
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
            while(top<5)
            {
                Console.Write("Igrese: ");
                item = int.Parse(Console.ReadLine());
                top--;
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
                cola[top] = 0;
                top--;
            }
        }
        public void Mostrar()
        {
            foreach (int c in cola)
            {
                Console.WriteLine(c);
            }
        }
        public void removesecond()
        {
            if(!isEmpty())
            {
                cola[second] = 0;
                second++;
            }
            
        }
    }
}
