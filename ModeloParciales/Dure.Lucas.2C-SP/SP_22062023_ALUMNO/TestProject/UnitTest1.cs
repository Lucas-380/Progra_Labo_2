using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using Entidades.Excepciones;
using Entidades.Exceptions;
using Entidades.Modelos;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        //a.Forzar, mediante el código la ejecución de FileManagerException, validar que suceda de forma correcta.
        [TestMethod]
        [ExpectedException(typeof(FileManagerException))]
        public void ForzarExcepcionAlCrearUnDirectorio()
        {
            //Arrange
            string directory = "directorioInexistente";

            //Act
            

            //No hace falta el assert en test de exceptions
        }


        [TestMethod]
        public void InstanciarUnNuevoCocineroLaCantidadDePedidosActualizadoDebeSerCero()
        {
            //Arrange
            int esperando = 0;

            //Act
            Cocinero<Hamburguesa> nuevoCocinero = new Cocinero<Hamburguesa>("Ramon");

            //assert
            Assert.AreEqual(nuevoCocinero.CantPedidosFinalizados, esperando);
        }
    }
}