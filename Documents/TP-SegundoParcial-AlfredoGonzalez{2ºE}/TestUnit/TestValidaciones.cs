using Microsoft.VisualStudio.TestTools.UnitTesting;
using entidades;
using entidades.Excepciones;

namespace TestUnit
{
    [TestClass]
    public class TestValidaciones
    {

        [TestMethod]
        [ExpectedException(typeof(NombreInvalidoExcepcion))]
        public void ValidarNombre_CuandoRecibeMenosDe3Letras_DeberiaLanzarNombreInvalidoException()
        {
            //Arrange
            string nombre = "ag";

            //Act
            bool actual = Validar.ValidarNombre(nombre);

            //Assert

        }
        [TestMethod]
        [ExpectedException(typeof(NombreInvalidoExcepcion))]
        public void ValidarNombre_CuandoRecibeMasDe20Letras_DeberiaLanzarNombreInvalidoException()
        {
            //Arrange
            string nombre = "caaaaaaaaaaaajskadjkaskjsakjadjkjkasjkddjkaskjsa";

            //Act
            bool actual = Validar.ValidarNombre(nombre);

            //Assert
        }
        [TestMethod]
        [ExpectedException(typeof(NombreInvalidoExcepcion))]
        public void ValidarNombre_CuandoRecibeNumeros_DeberiaLanzarNombreInvalidoException()
        {
            //Arrange
            string nombre = "alfred1234";

            //Act
            bool actual = Validar.ValidarNombre(nombre);

            //Assert
        }
    }
}
