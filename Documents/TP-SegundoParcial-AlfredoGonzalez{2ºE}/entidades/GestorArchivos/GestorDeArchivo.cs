using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.GestorArchivos
{
    public abstract class GestorDeArchivo
    {
        public enum ETipoArchivo { CSV, JSON};
        protected string rutaBase;
        protected ETipoArchivo tipoArchivo;


        protected GestorDeArchivo(ETipoArchivo tipoArchivo) 
        {
            string nombreCarpeta = "Archivos";
            DirectoryInfo ruta = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{nombreCarpeta}\\{tipoArchivo}\\");
            rutaBase = ruta.FullName;
            this.tipoArchivo = tipoArchivo;
        }
    }
}
