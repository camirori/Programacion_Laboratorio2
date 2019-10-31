using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
using CentralTelefonica;
using Ej44Guia_TestUnitarios_Clase18;

namespace Ej44Guia_TestUnitarios_Clase18
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*test unitario que valide que la lista de llamadas de la centralita esté instanciada al
              crear un nuevo objeto del tipo Centralita*/

            //arrange
            /* La sección Arrange de un método de prueba unitaria inicializa objetos y
                establece el valor de los datos que se pasa al método en pruebas*/
            Centralita testLista = new Centralita();


            //act
            /* invoca al método en pruebas con los parámetros organizados*/
            bool actual = (testLista.Llamadas != null) ? true : false;

            //assert
            /* comprueba si la acción del método en pruebas se comporta de la forma prevista*/
            Assert.AreEqual(true, actual);

        }
    }
}
