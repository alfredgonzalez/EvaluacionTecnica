using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.Excepciones
{
    public class CamposVaciosONullExcepcion : Exception
    {
        public CamposVaciosONullExcepcion(string message) : base(message)
        {
        }

        public CamposVaciosONullExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
