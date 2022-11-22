using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class UsuarioNoExisteExcepcion : Exception
    {
        public UsuarioNoExisteExcepcion(string message) : base(message)
        {
        }

        public UsuarioNoExisteExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
