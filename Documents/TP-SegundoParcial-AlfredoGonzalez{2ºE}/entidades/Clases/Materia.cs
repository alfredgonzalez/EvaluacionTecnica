using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades.Clases;

namespace entidades
{
    public class Materia
    {
        protected string nombre;
        protected int id;
        protected string cuatrimestre;
        protected int idCorrelativa;
        protected List<Profesor> profesores;
        protected List<Alumno> alumnos;
        


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuatrimestre { get => cuatrimestre; set => cuatrimestre = value; }
        public int IdCorrelativa { get => idCorrelativa; set => idCorrelativa = value; }
        public List<Profesor> Profesores { get => profesores; set => profesores = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }




        public Materia() 
        {
            this.profesores = new List<Profesor>();
            this.alumnos = new List<Alumno>();
        }
        public Materia (string nombre, string cuatrimestre) :this()
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
        }
        public Materia(int id,string nombre, string cuatrimestre) :this(nombre, cuatrimestre)
        {
            
        }

        public Materia(int id, string nombre, string cuatrimestre, int idCorrelativa) : this(id, nombre, cuatrimestre) 
        {
            this.id = id;
            this.idCorrelativa = idCorrelativa;
  
        }
        /// <summary>
        /// overridea sqldatareader para generar un constructor con los datos salientes de la DB
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Materia(SqlDataReader v)
        {
            Materia p = new Materia(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                v["cuatrimestre"].ToString() ?? "",
                Convert.ToInt32(v["idCorrelativa"])
                );

            return p;
        }
        /// <summary>
        /// override del tostring para imprimir los datos necesarios
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append($"ID: {this.Id} - Nombre: {this.Nombre} - Cuatrimestre: {this.Cuatrimestre} - IdCorrelativa: {this.IdCorrelativa}");

            return sb.ToString();
        }



        /// <summary>
        /// compara que el alumno se encuentre en la lista de materias
        /// </summary>
        /// <param name="alumnos"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Materia alumnos, Alumno a)
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
        /// compara que el alumno no se encuentre en la lista de materias
        /// </summary>
        /// <param name="alumnos"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Materia alumnos, Alumno a)
        {
            return !(alumnos == a);
        }
        public static string operator +(Materia alumnos, Alumno a)
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


    }
    

}
