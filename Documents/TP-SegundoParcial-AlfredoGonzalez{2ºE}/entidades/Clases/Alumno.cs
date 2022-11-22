using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace entidades
{
    public enum Estado { Regular, Irregular};
    public class Alumno : Persona
    {
        private int id;
        private Estado estado;
        private List<KeyValuePair<String, String>> estadoMaterias;
        private string materiaUno;
        private string materiaDos;
        private int notaUno;
        private int notaDos;
        private List<Materia> materiasAprobadas;

        public Alumno()
        {
        }
        public Alumno(string nombre, string apellido) : base(nombre, apellido)
        {
            this.estadoMaterias = new List<KeyValuePair<String, String>>();
        }

        public Alumno(int id, string nombre, string apellido) : this(nombre, apellido)
        {
            
            this.id = id;
            this.materiasAprobadas = new List<Materia>();
    
        }
        public Alumno(int id, string nombre, string apellido, string materiaUno, string materiaDos) :this(id, nombre, apellido)
        {
            this.materiaUno = materiaUno;
            this.materiaDos = materiaDos;
        }

 
        public Estado Estado { get { return estado; } set { estado = value; } }
        public override EUsuario Usuario { get { return EUsuario.alumno; } }

        public int Id { get { return id; } }

        public string MateriaUno { get { return materiaUno; } set { materiaUno = value; } }
        public string MateriaDos { get { return materiaDos; } set { materiaDos = value; } }

        public List<KeyValuePair<String, String>> EstadoMaterias { get { return estadoMaterias; } set { estadoMaterias = value; } }

        public int NotaUno { get => notaUno; set => notaUno = value; }
        public int NotaDos { get => notaDos; set => notaDos = value; }
        public List<Materia> MateriasAprobadas { get => materiasAprobadas; set => materiasAprobadas = value; }

        /// <summary>
        /// carga los estados de las materias
        /// </summary>
        /// <returns></returns>
        public string CargarEstadosMaterias() 
        {
            string mensaje = "Estados cargados";

            this.EstadoMaterias.Add(new KeyValuePair<String, String>(MateriaUno, "Regular"));
            this.EstadoMaterias.Add(new KeyValuePair<String, String>(MateriaDos, "Regular"));

            return mensaje;
        }
        /// <summary>
        /// overridea sqldataread para hacer un contructor con los parametros que llegan de la BD
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Alumno(SqlDataReader v)
        {
                Alumno p = new Alumno(
                Convert.ToInt32(v["Id"]),
                v["Nombre"].ToString() ?? "",
                v["Apellido"].ToString() ?? "",
                v["materiaUno"].ToString() ?? "",
                v["materiaDos"].ToString() ?? ""
                )
                ;

            return p;
        }
        /// <summary>
        /// override tostring y agrega sus datos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            CargarEstadosMaterias();

            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());

            return sb.ToString();
        }
    }
}
