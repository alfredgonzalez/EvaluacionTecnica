using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaIngresada;
            string nombreIngresado;
            int antiguedadIngresada;
            int horasTrabajadasIngresada;
            int cantidadEmpleados;
            float importeACobrarSinDescuento;
            float importeACobrar;
            float descuento;


            Console.WriteLine("Ingrese la cantidad de empleados");
            cantidadEmpleados = int.Parse(Console.ReadLine());
            for(int i = 0; i < cantidadEmpleados; i++) 
            {
                Console.WriteLine("Ingrese las horas ");
                horaIngresada = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre ");
                nombreIngresado = Console.ReadLine();
                Console.WriteLine("Ingrese los años de antiguedad ");
                antiguedadIngresada = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese las horas trabajadas ");
                horasTrabajadasIngresada = int.Parse(Console.ReadLine());
                importeACobrarSinDescuento = (horaIngresada * horasTrabajadasIngresada) + (antiguedadIngresada * 150);
                descuento = (importeACobrarSinDescuento * 13) / 100;
                importeACobrar = importeACobrarSinDescuento - descuento;
                Console.WriteLine($"Nombre:{nombreIngresado}. Antiguedad:{antiguedadIngresada}. " +
                    $"valor hora:{horaIngresada}. total bruto: {importeACobrarSinDescuento}. total neto:{importeACobrar}");
                Console.ReadKey();
            }



        }
        /*Empleado emp1 = new Empleado(0, "xxxx", 0, 0);
        Console.WriteLine("Ingrese las horas ");
        horaIngresada = int.Parse(Console.ReadLine());
        emp1.SetHora(horaIngresada);
        Console.WriteLine("Ingrese el nombre ");
        nombreIngresado = Console.ReadLine();
        emp1.SetNombre(nombreIngresado);
        Console.WriteLine("Ingrese los años de antiguedad ");
        antiguedadIngresada = int.Parse(Console.ReadLine());
        emp1.SetAnios(antiguedadIngresada);*/

    }
}
