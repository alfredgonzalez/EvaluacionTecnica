using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades.Excepciones;
using entidades.Interfaces;
using ServiceStack;

namespace entidades.GestorArchivos
{
    public class ArchivoCSV<T> : GestorDeArchivo, IArchivos<T> where T : class, new()
    {

        public ArchivoCSV(ETipoArchivo archivo) : base(ETipoArchivo.CSV) 
        {

        }
        public string Escribir(string nombreArchivo, T contenido)
        {
            try
            {
                string ruta = $"{rutaBase}\\{nombreArchivo}{DateTime.Now.ToString("D")}.csv";
                string resultado = contenido.ToCsv();
                System.IO.File.WriteAllText(ruta, resultado);

                return "Datos guardados en csv correctamente";
            }
            catch (Exception)
            {
                throw new ArchivoCsvExcepcion("Error al guardar los datos en formato CSV");
            }

        }
    }
}
