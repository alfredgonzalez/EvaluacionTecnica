using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string triangulo;

            Console.WriteLine("Ingresa la altura del triangulo: ");
            numeroIngresado = int.Parse(Console.ReadLine());
            triangulo = "*";

            for(int i=0; i< numeroIngresado; i++) 
            {
                Console.WriteLine(triangulo);
                triangulo = triangulo + "**";

            }
        }
    }
}
