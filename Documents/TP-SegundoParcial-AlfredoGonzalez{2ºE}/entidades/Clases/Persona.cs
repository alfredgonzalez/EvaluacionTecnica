using System;
using System.Text;

namespace entidades
{
    public enum EUsuario { admin = 0, profesor = 1, alumno = 2 }
    public abstract class Persona
    {
        
        protected string nombre;
        protected string apellido;
        protected EUsuario usuario;

        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public abstract EUsuario Usuario { get; }


        public Persona() 
        {
            
        }
        public Persona(string nombre, string apellido) : this()
        {
           
            this.nombre = nombre;
            this.apellido = apellido;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido: {p.Nombre} {p.Apellido}");
            
            return sb.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ((string)this);
        }
    }
}
