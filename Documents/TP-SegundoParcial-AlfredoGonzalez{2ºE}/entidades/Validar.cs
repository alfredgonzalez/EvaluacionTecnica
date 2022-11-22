using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades.Excepciones;

namespace entidades
{
    public static class Validar
    {
        /// <summary>
        /// valida los campos que se ingresa como parametros y lanza una excepcion
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        /// <exception cref="CamposVaciosONullExcepcion"></exception>
        public static bool ValidarCamposPersona(string nombre, string apellido)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) )
            {
                throw new CamposVaciosONullExcepcion("Cargar todos los datos");
            }
            return true;

        }
        /// <summary>
        /// valida los campos ingresados como parametros y lanza una excepcion en caso de error
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        /// <exception cref="CamposVaciosONullExcepcion"></exception>
        public static bool ValidarCamposPersona(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new CamposVaciosONullExcepcion("Cargar todos los datos");
            }
            return true;

        }
        /// <summary>
        /// valida los campos ingresados como parametros y lanza una excepcion en caso de error
        /// </summary>
        /// <param name="apellido"></param>
        /// <returns></returns>
        /// <exception cref="ApellidoInvalidoExcepcion"></exception>
        public static bool ValidarApellido(string apellido)
        {
            if (apellido.Length > 20 || apellido.Length < 3)
            {
                throw new ApellidoInvalidoExcepcion("El apellido tiene que tener más de 3 letras y menos de 20");
            }
            else if (!apellido.VerificarContieneSoloLetras())
            {
                throw new ApellidoInvalidoExcepcion("El apellido tiene que contener solo letras.");
            }
            return true;
        }
        /// <summary>
        /// valida los campos ingresados como parametros y lanza una excepcion en caso de error
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        /// <exception cref="NombreInvalidoExcepcion"></exception>
        public static bool ValidarNombre(string nombre)
        {
            if (nombre.Length > 20 || nombre.Length < 3)
            {
                throw new NombreInvalidoExcepcion("El nombre tiene que tener más de 3 letras y menos de 20");
            }
            else if (!nombre.VerificarContieneSoloLetras())
            {
                throw new NombreInvalidoExcepcion("El nombre tiene que contener solo letras.");
            }
            return true;
        }
        /// <summary>
        /// valida los campos ingresados como parametros y lanza una excepcion en caso de error
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public static bool VerificarContieneSoloLetras(this String dato)
        {
            dato = dato.Trim();
            foreach (char letra in dato)
            {
                if (!Char.IsLetter(letra) && letra.ToString() != " ")
                    return false;
            }
            return true;
        }
    }
}
