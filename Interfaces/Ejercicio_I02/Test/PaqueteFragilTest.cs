namespace Test
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange
            PaqueteFragil paqueteFragil = new PaqueteFragil("test", 100, "test", "test", 1);

            //Act
            bool retorno = paqueteFragil.TienePrioridad;

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 35;

            PaqueteFragil paqueteFragil = new PaqueteFragil("test", costoEnvio, "test", "test", 1);

            //Act
            decimal retorno = paqueteFragil.Impuestos;

            //Assert
            Assert.AreEqual(valorEsperado, retorno);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 135;

            PaqueteFragil paqueteFragil = new PaqueteFragil("test", costoEnvio, "test", "test", 1);

            //Act
            decimal retorno = paqueteFragil.AplicarImpuestos();

            //Assert
            Assert.AreEqual(valorEsperado, retorno);
        }




    }
}