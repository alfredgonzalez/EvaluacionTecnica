using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aumento=1;
            double numero;
            string datoIngresado;
            bool resultado;
            double acumuladorAtras;
            double acumuladorAdelante;


            Console.WriteLine("Ingrese un numero: ");
            datoIngresado = Console.ReadLine();
            resultado = double.TryParse(datoIngresado, out numero);
            while(!resultado || numero <= 0) 
            {
                Console.WriteLine("Error. vuelva a ingresar un numero: ");
                datoIngresado = Console.ReadLine();
                resultado = double.TryParse(datoIngresado, out numero);
            }

            while (aumento < numero) 
            {
                aumento++;
                acumuladorAtras = 0;
                acumuladorAdelante = 0;
                for (double i = 0; i < numero - 1; i++)
                {
                    acumuladorAtras = acumuladorAtras + i;
                }
                for (double j = aumento + 1; j <= acumuladorAtras; j++) 
                {
                    if((acumuladorAtras == acumuladorAdelante) ||(acumuladorAdelante > acumuladorAtras))
                    {
                        break;
                    }
                    acumuladorAdelante = acumuladorAdelante + j;
                }
                if (acumuladorAdelante == acumuladorAtras) 
                {
                    Console.WriteLine("El centro numerico es: {0} y la acumulacion de los numeros son {1}(atras) y {2}(adelante)",numero, acumuladorAtras, acumuladorAdelante);
                }

            }
            Console.ReadLine();


        }
    }
}
