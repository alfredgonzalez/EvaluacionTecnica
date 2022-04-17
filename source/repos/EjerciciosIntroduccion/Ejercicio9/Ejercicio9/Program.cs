using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas;
            string filasIngresadas;

            Console.WriteLine("Ingrese la cantidad de filas ");
            filasIngresadas = Console.ReadLine();

            if(Int32.TryParse(filasIngresadas, out filas)) 
            {
                for(int i = 1; i < filas; i++) 
                {
                    for(int j = 1; j < filas - i; j++) 
                    {
                        Console.Write(" ");
                    }
                    for(int k = 1; k < (i*2); k++) 
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
