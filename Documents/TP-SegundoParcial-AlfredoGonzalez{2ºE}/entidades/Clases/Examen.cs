using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.Clases
{
    public class Examen
    {
        private int id;
        private int idMateria;
        private int idProfesor;
        private DateTime date;
        private string nombre;

        public Examen()
        {
        }
        public Examen(int id, string nombre, int idMateria, int idProfesor, DateTime date):this()
        {
            this.id = id;
            this.idMateria = idMateria;
            this.idProfesor = idProfesor;
            this.date = date;
            this.nombre = nombre;
        }
        public int Id { get => id; set => id = value; }
        public int IdMateria { get => idMateria; set => idMateria = value; }
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// overridea sqldatareader para generar un constructor con los datos salientes de la DB
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Examen(SqlDataReader v)
        {
            Examen p = new Examen(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                Convert.ToInt32(v["idMateria"]),
                Convert.ToInt32(v["idProfesor"]),
                Convert.ToDateTime(v["fecha"])
                );

            return p;
        }
        /// <summary>
        /// overridea tostring para usarlo con un stringbuilder e imprimir los datos
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ID: {id}- Materia: {Nombre} - Fecha: {Date}");

            return sb.ToString();
        }
    }
}
