using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;
            string datoIngresadoA;
            string datoIngresadoB;
            bool resultadoA;
            bool resultadoB;

            Console.WriteLine("Ingresa el año de inicio: ");
            datoIngresadoA = Console.ReadLine();
            resultadoA = int.TryParse(datoIngresadoA, out anioInicio);

            while (!resultadoA || anioInicio <= 0) 
            {
                Console.WriteLine("Error. Reingresa el año de inicio: ");
                datoIngresadoA = Console.ReadLine();
                resultadoA = int.TryParse(datoIngresadoA, out anioInicio);
            }
            Console.WriteLine("Ingresa el año de final: ");
            datoIngresadoB = Console.ReadLine();
            resultadoB = int.TryParse(datoIngresadoB, out anioFin);
            while (!resultadoB || anioFin <= anioInicio)
            {
                Console.WriteLine("Error. Reingresa el año final: ");
                datoIngresadoB = Console.ReadLine();
                resultadoB = int.TryParse(datoIngresadoB, out anioFin);
            }

            for (int i = anioInicio; i <= anioFin; i++) 
            {
                if ((i % 4 == 0) || (i % 400 == 0)) 
                {
                    if (i % 100 == 0 && i % 400 != 0)
                    {
                        Console.WriteLine("No es bisiesto");
                    }
                    else 
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }
            Console.WriteLine(". Son bisiestos");
        }
    }
}
