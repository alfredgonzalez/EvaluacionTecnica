using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.Excepciones
{
    public class CargaInvalidaSQLExcepcion : Exception
    {
        public CargaInvalidaSQLExcepcion(string message) : base(message)
        {
        }
    }
}
