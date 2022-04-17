using System;

namespace Entidades
{
    public class Empleado
    {
        private int hora;
        private string nombre;
        private int anios;
        private int horasTrabajadas;


        public Empleado(int hora, string nombre, int anios, int horasTrabajadas) 
        {
            this.hora = hora;
            this.nombre = nombre;
            this.anios = anios;
            this.horasTrabajadas = horasTrabajadas;
        }


        public int GetHorasTrabajadas()
        {
            return this.horasTrabajadas;
        }

        public void SetHorasTrabajadas(int value)
        {
            if (value > 0)
            {
                this.horasTrabajadas = value;
            }
        }

        public int GetAnios()
        {
            return this.anios;
        }

        public void SetAnios(int value)
        {
            if (value > 0)
            {
                this.anios = value;
            }
        }
        public int GetHora()
        {
            return this.hora;
        }

        public void SetHora(int value)
        {
            if (value > 0)
            {
                this.hora = value;
            }
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.nombre = value;
            }
        }
    }
}
