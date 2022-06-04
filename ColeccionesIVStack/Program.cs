using System;
using System.Collections.Generic;

namespace ColeccionesIVStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            foreach (int numero in new int[5] { 10, 2, 4, 6, 8 })
            {//agrega a la cola o encola los numeros del array
                numeros.Push(numero);
            }
            Console.WriteLine("Recorrer el stack");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            //eliminando elementos del stack
            Console.WriteLine("eliminando elementos");
            numeros.Pop();
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
