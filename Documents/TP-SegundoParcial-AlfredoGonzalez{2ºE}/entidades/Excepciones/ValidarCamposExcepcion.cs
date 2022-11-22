using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class ValidarCamposExcepcion : Exception
    {
        public ValidarCamposExcepcion(string mensaje) : base(mensaje)
        {
        }
    }
}
