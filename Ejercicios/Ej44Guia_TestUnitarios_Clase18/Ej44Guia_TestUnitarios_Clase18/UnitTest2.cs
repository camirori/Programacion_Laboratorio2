using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using CentralTelefonica;
using Ej44Guia_TestUnitarios_Clase18;

namespace Ej44Guia_TestUnitarios_Clase18
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*b. Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
                se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
                destino de una llamada Local ya existente.*/

            //arrange
            /* La sección Arrange de un método de prueba unitaria inicializa objetos y
                establece el valor de los datos que se pasa al método en pruebas*/
            Centralita central = new Centralita();
            Local local1 = new Local("1", 1, "1", 1);
            Local local2 = new Local("1", 2, "1", 2);
            bool actual;

            //act
            /* invoca al método en pruebas con los parámetros organizados*/
            try
            {
                central += local1;
                central += local2;
            }
            catch(CentralitaException a)
            {
                actual = true;
            }


            //assert
            /* comprueba si la acción del método en pruebas se comporta de la forma prevista*/
            Assert.AreEqual(true, actual);
        }
    }
}
