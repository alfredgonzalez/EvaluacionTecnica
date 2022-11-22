using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidades.Excepciones;
using entidades.Clases;
namespace entidades
{
    public class GestorSQL
    {

        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;


        static GestorSQL()
        {
            _sqlConnection = new SqlConnection(@"Data Source = .;Database = parcial_dos;Trusted_Connection = True;");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }
        /// <summary>
        /// Guarda el alumno ingresado como parametro en la base de datos
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarAlumno(Alumno alumno)
        {
            int retorno = 0;
            List<String> listAux = new List<String>();
            
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO alumno (nombre, apellido) VALUES(@nombreAlumno, @apellidoAlumno)";

                _sqlCommand.Parameters.AddWithValue("@nombreAlumno", alumno.Nombre);
                _sqlCommand.Parameters.AddWithValue("@apellidoAlumno", alumno.Apellido);


                retorno = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar datos de alumno");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda el profesor ingresado como parametro en la base de datos
        /// </summary>
        /// <param name="profesor"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarProfesor(Profesor profesor)
        {
            int retorno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO profesor (nombre, apellido) VALUES(@nombreProfesor, @apellidoProfesor)";

                _sqlCommand.Parameters.AddWithValue("@nombreProfesor", profesor.Nombre);
                _sqlCommand.Parameters.AddWithValue("@apellidoProfesor", profesor.Apellido);

                retorno = _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar datos de profesor");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda la materia ingresada como parametro en la base de datos
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarMateria(Materia materia)
        {
            int retorno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO materia (nombre, cuatrimestre, idCorrelativa) VALUES(@nombreMateria, @cuatrimestreMateria, @idCorrelativaMateria)";

                _sqlCommand.Parameters.AddWithValue("@nombreMateria", materia.Nombre);
                _sqlCommand.Parameters.AddWithValue("@cuatrimestreMateria", materia.Cuatrimestre);
                _sqlCommand.Parameters.AddWithValue("@idCorrelativaMateria", materia.IdCorrelativa);

                retorno = _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar datos de Materia");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda la materia correlativa ingresada como parametro en la base de datos
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarMateriaCorrelativa(Materia materia)
        {
            int retorno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO materiaCorrelativa (idMateria, descripcion) VALUES(@idMateria, @nombreMateriaCorrelativa)";

                _sqlCommand.Parameters.AddWithValue("@nombreMateriaCorrelativa", materia.Nombre);
                _sqlCommand.Parameters.AddWithValue("@idMateria", materia.Id);


                retorno = _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar datos de Materia correlativa");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda la materia ingresada como parametros en los datos de las materias en curso del alumno
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="alumno"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarMateriaAlumno(Materia materia, Alumno alumno)
        {
            int retorno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO materiasAlumno (idMateria, idAlumno) VALUES(@idMateriaInscripcionAMateria, @idAlumnoInscripcionAMateria)";

                _sqlCommand.Parameters.AddWithValue("@idMateriaInscripcionAMateria", materia.Id);
                _sqlCommand.Parameters.AddWithValue("@idAlumnoInscripcionAMateria", alumno.Id);


                retorno = _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar datos de Materia inscripta");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda la materia asignada ingresada como parametros  en la base de materias dictando de los profesores
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="profesor"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarMateriaAsignada(Materia materia, Profesor profesor)
        {
            int retorno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO materiasProfesor (idMateria, idProfesor) VALUES(@idMateriaAsignada, @idProfesorAsignado)";

                _sqlCommand.Parameters.AddWithValue("@idMateriaAsignada", materia.Id);
                _sqlCommand.Parameters.AddWithValue("@idProfesorAsignado", profesor.Id);


                retorno = _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar datos de Materia asignada");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda un examen tomando como parametro los datos de la materia, y el profesor que la dicta
        /// </summary>
        /// <param name="materia"></param>
        /// <param name="profesor"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarExamen(Materia materia, Profesor profesor, DateTime date)
        {
            int retorno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO examenes (idMateria, idProfesor, fecha) VALUES(@idMateria, @idProfesor, @fecha)";

                _sqlCommand.Parameters.AddWithValue("@idMateriaExamen", materia.Id);
                _sqlCommand.Parameters.AddWithValue("@idProfesorExamen", profesor.Id);
                _sqlCommand.Parameters.AddWithValue("@fechaExamen", date);


                retorno = _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar datos de examen");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda la nota del examen junto con los datos del alumno y la materia a la cual esta relacionada ese examen
        /// </summary>
        /// <param name="examen"></param>
        /// <param name="alumno"></param>
        /// <param name="nota"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarNotaExamen(Examen examen, Alumno alumno, int nota)
        {
            int retorno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO notas (idExamen, idAlumno, nota) VALUES(@idExamenNota, @idAlumnoNota, @notaExamen)";

                _sqlCommand.Parameters.AddWithValue("@idExamenNota", examen.Id);
                _sqlCommand.Parameters.AddWithValue("@idAlumnoNota", alumno.Id);
                _sqlCommand.Parameters.AddWithValue("@notaExamen", nota);



                retorno = _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar la nota");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda la materia aprobada del alumno
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="materia"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static string GuardarMateriaAprobadaAlumno(Alumno alumno, Materia materia)
        {
            string retorno = "Error!";
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO materiasAprobadas (idMateria,idAlumno, notaUno, notaDos) VALUES( @idMateria, @idAlumno,@notaUno, @notaDos)";

                _sqlCommand.Parameters.AddWithValue("@idAlumno", alumno.Id);
                _sqlCommand.Parameters.AddWithValue("@idMateria", materia.Id);
                _sqlCommand.Parameters.AddWithValue("@notaUno", alumno.NotaUno);
                _sqlCommand.Parameters.AddWithValue("@notaDos", alumno.NotaDos);


                retorno = "Materias aprobadas guardadas";
                _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar materias aprobadas");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// guarda la asistencia tomada por el alumno, junto con la materia en la cual se da asistencia y la fecha
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="materia"></param>
        /// <param name="fecha"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static string GuardarAsistencia(Alumno alumno, Materia materia, DateTime fecha)
        {
            string retorno = "Error!";
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO asistencias (idAlumno, idMateria, fecha) VALUES(@idAlumnoAsistencia, @idMateriaAsistencia, @fechaAsistencia)";

                _sqlCommand.Parameters.AddWithValue("@idAlumnoAsistencia", alumno.Id);
                _sqlCommand.Parameters.AddWithValue("@idMateriaAsistencia", materia.Id);
                _sqlCommand.Parameters.AddWithValue("@fechaAsistencia", fecha);


                retorno = "Asistencia guardada";
                _sqlCommand.ExecuteNonQuery();
            }

            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar asistencia");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// lee las asistencias realizadas por el alumno
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<String> LeerAsistencias(Alumno alumno)
        {
            List<String> list = new List<String>();
            string datos = string.Empty;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "select distinct materia.nombre, asistencias.fecha from materiasAlumno inner join asistencias on asistencias.idMateria = materiasAlumno.idMateria inner join alumno on asistencias.idAlumno = @idAlumnoAsistencias inner join materia on materia.id = materiasAlumno.idMateria";


                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idAlumnoAsistencias", alumno.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    datos = $"Alumno: {alumno.Nombre} es regular en la Materia: {reader.GetString(0)} - con fecha de asistencia en : {Convert.ToDateTime(reader.GetString(1)).ToString()}";

                    list.Add(datos);
                }

            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("El alumno no cuenta con materias regulares");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee las materias aprobadas del alumno
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<String> LeerMateriasAprobadas(Alumno alumno)
        {
            List<String> list = new List<String>();
            string datos = string.Empty;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "select distinct materia.nombre, materiasAprobadas.notaUno, materiasAprobadas.notaDos from materiasAprobadas inner join alumno on alumno.id = materiasAprobadas.idAlumno inner join materia on materiasAprobadas.idMateria = materia.id where alumno.id = @idAlumnoMateriasAprobadas";

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idAlumnoMateriasAprobadas", alumno.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    datos = $"Materia: {reader.GetString(0)} - Nota uno: {reader.GetInt32(1)} - Nota dos: {reader.GetInt32(2)}";

                    list.Add(datos);
                }
                
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer Materias aprobadas del alumno");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }

        /// <summary>
        /// lee los alumnos que hay en esa materia
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Alumno> LeerAlumnoMateria(Materia materia)
        {
            List<Alumno> list = new List<Alumno>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT * FROM alumno a left join materiasAlumno ma on a.id = ma.idAlumno where ma.idMateria = @idMateriaLeerAlumno";

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idMateriaLeerAlumno", materia.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Alumno e = (Alumno)reader;


                    list.Add(e);
                }
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de alumnos");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee los examenes que hay para esa materia
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Examen> LeerExamen(Materia materia)
        {
            List<Examen> list = new List<Examen>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT e.id, m.nombre, e.idMateria, e.idProfesor, e.fecha FROM examenes e inner join materia m on m.id = e.idMateria and m.id = @idMateriaLeerExamen";

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idMateriaLeerExamen", materia.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Examen e = (Examen)reader;


                    list.Add(e);
                }
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de examen");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee las materias asignadas del profesor
        /// </summary>
        /// <param name="profesor"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Materia> LeerMateriaAsignada(Profesor profesor)
        {
            List<Materia> list = new List<Materia>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT distinct* FROM materia left join materiasProfesor on materia.id = materiasProfesor.idMateria where materiasProfesor.idProfesor = @idProfesorAsignada";

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idProfesorAsignada", profesor.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Materia materia = (Materia)reader;


                    list.Add(materia);
                }
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de materias");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee las materias disponibles para las inscripciones
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Materia> LeerMateriasParaInscripcion(Alumno alumno)
        {
            List<Materia> list = new List<Materia>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "select * from materia inner join  materiaCorrelativa on materia.idCorrelativa = materiaCorrelativa.id left join materiasAprobadas on materiasAprobadas.idAlumno = @idAlumnoMateriaInscripcion where materiasAprobadas.idMateria <> materia.idCorrelativa";

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idAlumnoMateriaInscripcion", alumno.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Materia materia = (Materia)reader;


                        list.Add(materia);
                    }

               
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de materias");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee la nota numero 1 del alumno
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="examen"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int LeerNotaUnoAlumno(Alumno alumno, Examen examen)
        {
            int retorno = 0;

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT TOP 1 nota FROM notas where notas.idExamen = @idExamen and notas.idAlumno = @idAlumno";

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idAlumno", alumno.Id);
                _sqlCommand.Parameters.AddWithValue("@idExamen", examen.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    retorno = (Int32)reader.GetInt32(0);
                }


            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer nota Uno");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// lee la nota numero dos del alumno
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="examen"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int LeerNotaDosAlumno(Alumno alumno, Examen examen)
        {
            int retorno = 0;

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "SELECT TOP 1 nota FROM notas where notas.idExamen = @idExamen and notas.idAlumno = @idAlumno order by notas.id desc";

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idAlumno", alumno.Id);
                _sqlCommand.Parameters.AddWithValue("@idExamen", examen.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    retorno = (Int32)reader.GetInt32(0);
                }


            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer nota Dos");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// lee las materias aprobadas del alumno y devuelve una lista de ellas
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Materia> LeerMateriasAprobadasAlumno(Alumno alumno)
        {
            List<Materia> list = new List<Materia>();

            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = "select distinct materia.id, materia.nombre, materia.cuatrimestre, materia.idcorrelativa from materiasAprobadas inner join alumno on alumno.id = materiasAprobadas.idAlumno inner join materia on materiasAprobadas.idMateria = materia.id where alumno.id = @idAlumnoLeerMateriasAprobadas";

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idAlumnoLeerMateriasAprobadas", alumno.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Materia materia = (Materia)reader;


                    list.Add(materia);
                }


            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de materias aprobadas");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// guarda el administrador ingresado como parametro en la base de datos
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int GuardarAdmin(Admin admin)
        {
            int retorno = 0;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();

                _sqlCommand.CommandText = "INSERT INTO admin (nombre, apellido) VALUES(@nombreAdmin, @apellidoAdmin)";

                _sqlCommand.Parameters.AddWithValue("@nombreAdmin", admin.Nombre);
                _sqlCommand.Parameters.AddWithValue("@apellidoAdmin", admin.Apellido);

                retorno = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new CargaInvalidaSQLExcepcion("Error al guardar datos de admin");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// lee la informacion de la tabla admins
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Admin> LeerAdmin()
        {
            List<Admin> list = new List<Admin>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM admin";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Admin persona = (Admin)reader;

                    //Console.WriteLine(persona);
                    list.Add(persona);
                }
            }
            catch (Exception)
            {
               throw new CargaInvalidaSQLExcepcion("Error al leer datos de admin");
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee todos los alumnos de la tabla alumno
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Alumno> LeerAlumno()
        {
            List<Alumno> list = new List<Alumno>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM alumno";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {

                    Alumno persona = (Alumno)reader;
                    //int dni = reader.GetInt32(0);
                    //string nombre = reader.GetString(1);
                    //string apellido = reader.GetString(2);
                    //int idMateriaUno = reader.GetInt32(3);
                    //int idMateriaDos = reader.GetInt32(4);

                    //Alumno auxAlumno = new Alumno(dni, nombre, apellido, idMateriaUno, idMateriaDos);
                    
                    list.Add(persona);
                }
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de alumno");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee todos los profesores de la tabla profesores
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Profesor> LeerProfesor()
        {
            List<Profesor> list = new List<Profesor>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM profesor";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Profesor persona = (Profesor)reader;

                    //Console.WriteLine(persona);
                    list.Add(persona);
                }
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de profesor");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee los id de la materia correlativa cuando se le pasa como parametro una descripcion
        /// </summary>
        /// <param name="descripcion"></param>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static int LeerIdCorrelativa(string descripcion) 
        {
            int retorno = 0;

            try
            {
                _sqlCommand.CommandText = $"SELECT id FROM materiaCorrelativa mc where mc.descripcion = '{descripcion}'";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    retorno = reader.GetInt32(0);
                }
                
                    //Console.WriteLine(persona);
               
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error el id de materiaCorrelativa");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// lee las materias inscriptas del alumno
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<Materia> LeerMateriaInscriptaAlumno(Alumno alumno)
        {
            List<Materia> list = new List<Materia>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM materia inner join materiasAlumno on materia.id = materiasAlumno.idMateria where materiasAlumno.idAlumno = @idMateriasInscriptaAlumno";
                

                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@idMateriasInscriptaAlumno", alumno.Id);
                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Materia materia = (Materia)reader;


                    list.Add(materia);
                }
            }
            catch (Exception)
            {
                throw new Exception();

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee las materias de la tabla materia
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<Materia> LeerMateria()
        {
            List<Materia> list = new List<Materia>();

            try
            {
                _sqlCommand.CommandText = "SELECT * FROM materia";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Materia materia = (Materia)reader;
                  

                    list.Add(materia);
                }
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de materiasss");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }
        /// <summary>
        /// lee las descripcion de las materias y las devuelve como una list de string
        /// </summary>
        /// <returns></returns>
        /// <exception cref="CargaInvalidaSQLExcepcion"></exception>
        public static List<String> LeerMateriaDescripcion()
        {
            List<String> list = new List<String>();

            try
            {
                _sqlCommand.CommandText = "SELECT descripcion FROM materiaCorrelativa left join materia on materiaCorrelativa.id = materia.idCorrelativa";

                _sqlConnection.Open();

                SqlDataReader reader = _sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader.GetString(0);


                    list.Add(nombre);
                }
            }
            catch (Exception)
            {
                throw new CargaInvalidaSQLExcepcion("Error al leer datos de materias");

            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return list;
        }

    }
}
