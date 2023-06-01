using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //Arrange
            const decimal valorEsperado = 70;

            GestionImpuestos impuestosTest = new GestionImpuestos();
            PaqueteFragil paqueteFragil = new PaqueteFragil("test1", 100, "test", "test", 1);
            PaquetePesado paquetePesado = new PaquetePesado("test2", 100, "test", "test", 1);

            impuestosTest.RegistrarImpuestos(paqueteFragil);
            impuestosTest.RegistrarImpuestos(paquetePesado);

            //Act
            decimal retorno = impuestosTest.CalcularTotalImpuestosAduana();
            
            //Assert
            Assert.AreEqual(valorEsperado, retorno);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            //Arrange
            const decimal valorEsperado = 125;

            GestionImpuestos impuestosTest = new GestionImpuestos();
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("test1", 100, "test", "test", 1));
            paquetes.Add(new PaquetePesado("test2", 200, "test", "test", 1));
            paquetes.Add(new PaquetePesado("test3", 300, "test", "test", 1));

            impuestosTest.RegistrarImpuestos(paquetes);

            //Act
            decimal retorno = impuestosTest.CalcularTotalImpuestosAfip();

            //Assert
            Assert.AreEqual(valorEsperado, retorno);
        }


    }
}
