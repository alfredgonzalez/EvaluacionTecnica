using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace entidades
{
    public class Admin : Persona
    {
        private int id;
        public Admin()
        {
        }

        public Admin(string nombre, string apellido) : this() 
        {
            this.nombre = nombre;
            this.apellido  = apellido;
        }
 
        public Admin(int id, string nombre, string apellido) : base( nombre, apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public override EUsuario Usuario { get { return EUsuario.admin; } }
        public int Id { get { return id; } }
        /// <summary>
        /// overridea el sqldatareader para usar sus datos como un constructor
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Admin(SqlDataReader v)
        {
            Admin p = new Admin(
                Convert.ToInt32(v["id"]),
                v["nombre"].ToString() ?? "",
                v["apellido"].ToString() ?? ""
                );

            return p;
        }
    }
}
