using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using entidades.Excepciones;
using entidades.Interfaces;

namespace entidades.GestorArchivos
{
    public class ArchivoJson<T> : GestorDeArchivo, IArchivos<T> where T : class, new() 
    {
        public ArchivoJson(ETipoArchivo tipoArchivo) : base(tipoArchivo) 
        {
        }
        public string Escribir(string nombreArchivo, T elemento)
        {
            try
            {

                if (this.tipoArchivo == ETipoArchivo.JSON)
                {
                    if (Path.GetExtension(nombreArchivo) == ".Json")
                    {

                        string rutaFinal = $"{rutaBase}\\{nombreArchivo}";

                        string json = JsonConvert.SerializeObject(elemento);
                        System.IO.File.WriteAllText(rutaFinal, json);
                        
                        return "Archivo guardado con exito";
                    }
                    else
                        throw new ArchivoSerializadorExcepcion("Extension invalida se esperaba Json.");
                }
                return "Formato invalido";
            }
            catch (Exception)
            {

                throw new ArchivoSerializadorExcepcion("Error al serializar.");
            }
        }
    }
}
