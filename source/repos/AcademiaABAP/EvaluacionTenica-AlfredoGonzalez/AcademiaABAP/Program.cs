using Entidades;
using System;
using System.Collections.Generic;

namespace AcademiaABAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado[] empleadosLista1 = new Empleado[6];
            Empleado[] empleadosLista2 = new Empleado[5];
            //Lista de empleados 1
            empleadosLista1[0] = new Empleado(1, "Juan");
            empleadosLista1[1] = new Empleado(2, "Andres");
            empleadosLista1[2] = new Empleado(8, "Fabian");
            empleadosLista1[3] = new Empleado(4, "Pedro");
            empleadosLista1[4] = new Empleado(10, "Lucia");
            empleadosLista1[5] = new Empleado(6, "Patricia");
            //Lista de empleados 2
            empleadosLista2[0] = new Empleado(1, "Alberto");
            empleadosLista2[1] = new Empleado(2, "Andres");
            empleadosLista2[2] = new Empleado(3, "Juana");
            empleadosLista2[3] = new Empleado(4, "Sebastian");
            empleadosLista2[4] = new Empleado(9, "Emiliano");

            //Ejercicio 1: Lista coincidencias
            List<Empleado> listaCoincidencias = new List<Empleado>(); //creacion de lista dinamica
            //For para recorrer ambas listas
            for (int i = 0; i < empleadosLista1.Length; i++)
            {
                for (int j = 0; j < empleadosLista2.Length; j++)
                {
                    if (empleadosLista1[i].GetId() == empleadosLista2[j].GetId() &&
                       empleadosLista1[i].GetName() == empleadosLista2[j].GetName()) 
                    {
                        listaCoincidencias.Add(empleadosLista1[i]);
                    }
                }
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Lista de coincidencias lista 1, lista 2: ");
            Console.WriteLine("-----------------------------------------");
            foreach (Empleado item in listaCoincidencias)
            {
                Console.WriteLine($"ID: {item.GetId()}\tNombre: {item.GetName()} ");
            }
            Console.WriteLine("\n");

            //Ejercicio 2: Lista perteneciente lista 1 faltante lista 2
            bool elementoFaltante;
            List<Empleado> listaFaltanteUno = new List<Empleado>();

            for (int i = 0; i < empleadosLista1.Length; i++)
            {
                elementoFaltante = true;
                for (int j = 0; j < empleadosLista2.Length; j++)
                {
                    if (empleadosLista1[i].GetId() == empleadosLista2[j].GetId() 
                        && empleadosLista1[i].GetName() == empleadosLista2[j].GetName())
                    {
                        elementoFaltante = false;
                        break;
                    }
                }
                if (elementoFaltante == true)
                {
                    listaFaltanteUno.Add(empleadosLista1[i]);
                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Elementos presentes lista 1, faltantes lista 2: ");
            Console.WriteLine("-------------------------------------------------");
            foreach (Empleado item in listaFaltanteUno)
            {
                Console.WriteLine($"ID: {item.GetId()}\tNombre: {item.GetName()}\n");
            }
            Console.WriteLine("\n");

            //Ejercicio 3: Lista perteneciente lista 2 faltante lista 1
            List<Empleado> listaFaltanteDos = new List<Empleado>();

            for (int i = 0; i < empleadosLista2.Length; i++)
            {
                elementoFaltante = true;
                for (int j = 0; j < empleadosLista1.Length; j++)
                {
                    if (empleadosLista2[i].GetId() == empleadosLista1[j].GetId() 
                        && empleadosLista2[i].GetName() == empleadosLista1[j].GetName())
                    {
                        elementoFaltante = false;
                        break;
                    }
                }
                if (elementoFaltante == true)
                {
                    listaFaltanteDos.Add(empleadosLista2[i]);
                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Elementos presentes lista 2, faltantes lista 1: ");
            Console.WriteLine("-------------------------------------------------");
            foreach (Empleado item in listaFaltanteDos)
            {
                Console.WriteLine($"ID: {item.GetId()}\tNombre: {item.GetName()}\n");
            }
            Console.WriteLine("\n");

            //Ejercicio 4: lista de elementos en conflictos (Pertenecen a ambas listas pero con distintos valores)
            List<Empleado> listaElementosConflicto = new List<Empleado>();

            for (int i = 0; i < empleadosLista1.Length; i++)
            {
                for (int j = 0; j < empleadosLista2.Length; j++)
                {
                    if (empleadosLista1[i].GetName() == empleadosLista2[j].GetName() 
                        && empleadosLista1[i].GetId() != empleadosLista2[j].GetId() 
                        ||empleadosLista1[i].GetName() != empleadosLista2[j].GetName() && 
                        empleadosLista1[i].GetId() == empleadosLista2[j].GetId())
                    {
                        listaElementosConflicto.Add(empleadosLista1[i]);
                        listaElementosConflicto.Add(empleadosLista2[j]);
                    }
                }
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Elementos en conflicto en ambas listas: ");
            Console.WriteLine("-----------------------------------------");
            foreach (Empleado item in listaElementosConflicto)
            {
                Console.WriteLine($"ID: {item.GetId()}\tNombre: {item.GetName()}\n");
            }
            Console.WriteLine("\n");
        }
    }
}
