using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int numero;
            string datoIngresado;
            string opcion= "no";

            numero = ValidarDato();

            while (numero != 1) 
            {
                ValidarPrimo(numero);
                numero--;
            }
            Console.WriteLine("Desea volver a iterar? Si/No");
            opcion = Console.ReadLine();
            while (opcion == "si") 
            {
                numero = ValidarDato();
                while (numero != 1)
                {
                    ValidarPrimo(numero);
                    numero--;
                }
                Console.WriteLine("Desea volver a iterar? Si/No");
                opcion = Console.ReadLine();
            }
            Console.WriteLine("Gracias por utilizar alfred app");

        }

        static int ValidarDato()
        {
            bool resultado;
            int numero;
            string datoIngresado;

            Console.WriteLine("Ingresa un numero: ");
            Console.WriteLine("Para cerrar la consola escribi salir");
            datoIngresado = Console.ReadLine();
            resultado = int.TryParse(datoIngresado, out numero);

            while (!resultado && datoIngresado != "salir" )
            {
                Console.WriteLine("Error. el dato ingresado no es numero");
                Console.WriteLine("Ingresa un numero: ");
                Console.WriteLine("Para cerrar la consola escribi salir");
                datoIngresado = Console.ReadLine();
                resultado = int.TryParse(datoIngresado, out numero);
            }
            if (datoIngresado == "salir")
            {
                Console.WriteLine("Gracias por utilizar alfred app");
                Console.ReadKey();
            }

            return numero;
        }

        static void ValidarPrimo(int numero) 
        {
            for (int i = 2; i < numero; i++) 
            {
                if (numero % i == 0)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine(" " + numero);
                    break;
                }
            }

        }
    }
}
