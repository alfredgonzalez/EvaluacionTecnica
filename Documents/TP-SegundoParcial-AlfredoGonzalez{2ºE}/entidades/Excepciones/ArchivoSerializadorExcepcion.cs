using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.Excepciones
{
    public class ArchivoSerializadorExcepcion : Exception
    {
        public ArchivoSerializadorExcepcion(string message) : base(message)
        {
        }
    }
}
