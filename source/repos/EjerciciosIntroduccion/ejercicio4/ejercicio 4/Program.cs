using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.MaxValue;
            int auxNumero;

            for (int i = 1; i <= numero; i++) 
            {
                auxNumero = 0;
                if (i % 2 == 0) 
                {
                    for(int j = 1; j<= (i/2); j++) 
                    {
                        if (i % j == 0) 
                        {
                            auxNumero = auxNumero + j;
                        }
                    }
                }
                if (auxNumero == i) 
                {
                    Console.WriteLine($"{auxNumero} Es numero perfecto");
                }
            }

        }
    }
}
