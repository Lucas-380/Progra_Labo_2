using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //Arrange
            PaquetePesado paquetePesado = new PaquetePesado("test", 100, "test", "test", 1);

            //Act
            bool retorno = paquetePesado.TienePrioridad;

            //Assert
            Assert.IsFalse(retorno);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 35;

            PaquetePesado paquetePesado = new PaquetePesado("test", costoEnvio, "test", "test", 1);

            //Act
            decimal retorno = paquetePesado.Impuestos;

            //Assert
            Assert.AreEqual(valorEsperado, retorno);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaIAfip()
        {
            //Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 25;

            PaquetePesado paquetePesado = new PaquetePesado("test", costoEnvio, "test", "test", 1);

            //Act
            decimal retorno = ((IAfip)paquetePesado).Impuestos;

            //Assert
            Assert.AreEqual(valorEsperado, retorno);
        }


        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            //Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 160;

            PaquetePesado paquetePesado = new PaquetePesado("test", costoEnvio, "test", "test", 1);

            //Act
            decimal retorno = paquetePesado.AplicarImpuestos();

            //Assert
            Assert.AreEqual(valorEsperado, retorno);
        }


    }
}
