using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Administracion
    {

        private List<Materia> materias;
        private List<Admin> admins;
        private List<Profesor> profesores;
        private List<Alumno> alumnos;



        public Administracion()
        {

            this.materias = new List<Materia>();
            this.admins = new List<Admin>();
            this.profesores = new List<Profesor>();
            this.alumnos = new List<Alumno>();
    }

        public List<Materia> Materias { get { return this.materias; } set { materias = value; } }
        public List<Admin> Admins { get { return this.admins; } set { this.admins = value; } }

        public List<Profesor> Profesores { get { return this.profesores; } set { this.profesores = value;} }
        public List<Alumno> Alumnos { get { return this.alumnos; } set { this.alumnos = value; } }


        public Materia BuscarMateria(string nombre) 
        {
            Materia materia = new Materia();
            foreach(Materia item in Materias) 
            {
                if(item.Nombre == nombre) 
                {
                    materia = item;
                }
            }
            return materia;
        }
        /// <summary>
        /// compara que el alumno este en la lista de alumnos de administracion
        /// </summary>
        /// <param name="alumnos"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Administracion alumnos, Alumno a)
        {
            if (alumnos.Alumnos is not null && a is not null)
            {
                foreach (Alumno item in alumnos.Alumnos)
                {
                    if (item == a)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        /// <summary>
        /// compara que el admin este en la lista de admins de administracion
        /// </summary>
        /// <param name="admins"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Administracion admins, Admin a)
        {
            if (admins.Admins is not null && a is not null)
            {
                foreach (Admin item in admins.Admins)
                {
                    if (item == a)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        /// <summary>
        /// compara que el profesor este en la lista de profesores de administracion
        /// </summary>
        /// <param name="profesores"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Administracion profesores, Profesor p)
        {
            if (profesores.Profesores is not null && p is not null)
            {
                foreach (Profesor item in profesores.Profesores)
                {
                    if (item == p)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        /// <summary>
        /// compara que la materia este en la lista de materias de administracion
        /// </summary>
        /// <param name="materias"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Administracion materias, Materia m)
        {
            if (materias.Materias is not null && m is not null)
            {
                foreach (Materia item in materias.Materias)
                {
                    if (item == m)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        /// <summary>
        /// compara que la materia no esta en la lista de materias
        /// </summary>
        /// <param name="materias"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator !=(Administracion materias, Materia m)
        {
            return !(materias == m);
        }
        /// <summary>
        /// compara que el profesor no se encuentre en la lista de profesores
        /// </summary>
        /// <param name="profesores"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Administracion profesores, Profesor p)
        {
            return !(profesores == p);
        }
        /// <summary>
        /// compara que el admin no se encuentre en la lista de admins
        /// </summary>
        /// <param name="admins"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Administracion admins, Admin a)
        {
            return !(admins == a);
        }
        /// <summary>
        /// compara que el alumno no se encuentre en la lista de alumnos
        /// </summary>
        /// <param name="alumnos"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Administracion alumnos, Alumno a)
        {
            return !(alumnos == a);
        }
        /// <summary>
        /// busca en la lista de alumnos si el alumno ingresado como parametro existe, si no existe lo agrega
        /// </summary>
        /// <param name="alumnos"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string operator +(Administracion alumnos, Alumno a)
        {
            string mensaje = "Error!";
            if (alumnos is not null && a is not null)
            {
                if (alumnos != a)
                {
                    alumnos.Alumnos.Add(a);
                    mensaje = "Agregado exitosamente!";
                    return mensaje;
                }
                mensaje = "El alumno ya existe!";
                return mensaje;
            }
            return mensaje;
        }
        /// <summary>
        /// busca en la lista de admins si el admin ingresado como parametro existe, si no existe lo agrega
        /// </summary>
        /// <param name="admins"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string operator +(Administracion admins, Admin a)
        {
            string mensaje = "Error!";
            if (admins is not null && a is not null)
            {
                if (admins != a)
                {
                    admins.Admins.Add(a);
                    mensaje = "Agregado exitosamente!";
                    return mensaje;
                }
                mensaje = "El admin ya existe!";
                return mensaje;
            }
            return mensaje;
        }
        /// <summary>
        /// busca en la lista de profesores si el profesor ingresado como parametro existe, si no existe lo agrega
        /// </summary>
        /// <param name="profesores"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string operator +(Administracion profesores, Profesor p)
        {
            string mensaje = "Error!";
            if (profesores is not null && p is not null)
            {
                if (profesores != p)
                {
                    profesores.Profesores.Add(p);
                    mensaje = "Agregado exitosamente!";
                    return mensaje;
                }
                mensaje = "El Profesor ya existe!";
                return mensaje;
            }
            return mensaje;
        }
        /// <summary>
        /// busca en la lista de Materias si el materias ingresado como parametro existe, si no existe lo agrega
        /// </summary>
        /// <param name="materias"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static string operator +(Administracion materias, Materia m)
        {
            string mensaje = "Error!";
            if (materias is not null && m is not null)
            {
                if (materias != m)
                {
                    materias.Materias.Add(m);
                    mensaje = "Agregado exitosamente!";
                    return mensaje;
                }
                mensaje = "La materia ya existe";
                return mensaje;
            }
            return mensaje;
        }
    }
}
