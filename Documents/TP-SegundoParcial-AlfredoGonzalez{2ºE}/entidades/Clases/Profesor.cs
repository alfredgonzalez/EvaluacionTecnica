using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace entidades
{
    public class Profesor : Persona
    {
        private int id;


        public Profesor()
        {
        }
        public Profesor(string nombre, string apellido) : this() 
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Profesor(int id, string nombre, string apellido) : base( nombre, apellido)
        {
            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public override EUsuario Usuario { get { return EUsuario.profesor; } }
        public int Id { get { return id; } }

        /// <summary>
        /// override del sqldatareader para generar un constructor con los datos proveniente de la DB
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Profesor(SqlDataReader v)
        {
            Profesor p = new Profesor(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                v["apellido"].ToString() ?? ""
                );

            return p;
        }
        /// <summary>
        /// imprime los datos overrideando el tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());

            return sb.ToString();
        }
    }
}
