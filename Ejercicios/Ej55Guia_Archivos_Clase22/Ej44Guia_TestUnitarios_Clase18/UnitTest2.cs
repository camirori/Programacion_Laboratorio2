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
        public void CentralitaAddLocal_ShouldThrowExc()
        {
            /*b. Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
                se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
                destino de una llamada Local ya existente.*/

            //arrange
            /* La sección Arrange de un método de prueba unitaria inicializa objetos y
                establece el valor de los datos que se pasa al método en pruebas*/
            Centralita central = new Centralita();
            Local local1 = new Local("1", 1, "1", 1);
            Local local2 = new Local("2", 2, "2", 2);
            Local local3 = new Local("2", 2, "2", 2);
            bool actual1 = false;
            bool actual2 = false;
            bool excpected1 = false;
            bool excpected2 = true;

            //act
            /* invoca al método en pruebas con los parámetros organizados*/
            try
            {
                central += local1;
                central += local2;
            }
            catch(CentralitaException)
            {
                actual1 = true;
            }
            try
            {
                central += local3;
            }
            catch (CentralitaException)
            {
                actual2 = true;
            }


            //assert
            /* comprueba si la acción del método en pruebas se comporta de la forma prevista*/
            Assert.AreEqual(excpected1, actual1);
            Assert.AreEqual(excpected2, actual2);
            
        }

        [TestMethod]
        public void CentralitaAddProvincial_ShouldThrowExc()
        {
            /*c. Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion se lance al intentar cargar una segunda 
             * llamada con solamente los mismos datos de origen y destino de una llamada Provincial ya existente. */

            //arrange
            /* La sección Arrange de un método de prueba unitaria inicializa objetos y
                establece el valor de los datos que se pasa al método en pruebas*/
            Centralita central = new Centralita();
            Provincial local1 = new Provincial("1", Provincial.Franja.Franja_1, 1,"2");
            Provincial local2 = new Provincial("2", Provincial.Franja.Franja_1, 1, "3");
            Provincial local3 = new Provincial("2", Provincial.Franja.Franja_1, 1, "3");
            bool actual1 = false;
            bool actual2 = false;
            bool excpected1 = false;
            bool excpected2 = true;

            //act
            /* invoca al método en pruebas con los parámetros organizados*/
            try
            {
                central += local1;
                central += local2;
            }
            catch (CentralitaException)
            {
                actual1 = true;
            }
            try
            {
                central += local3;
            }
            catch (CentralitaException)
            {
                actual2 = true;
            }


            //assert
            /* comprueba si la acción del método en pruebas se comporta de la forma prevista*/
            Assert.AreEqual(excpected1, actual1);
            Assert.AreEqual(excpected2, actual2);

        }

        [TestMethod]
        public void CentralitaLlamada_AreSameType()
        {
            /*d. Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con los mismos datos de origen y destino. 
             * Luego comparar cada uno de estos cuatro objetos contra los demás, debiendo ser iguales solamente las instancias de Local y de Provincial entre sí. */

            //arrange
            /* La sección Arrange de un método de prueba unitaria inicializa objetos y
                establece el valor de los datos que se pasa al método en pruebas*/
            Provincial provincial1 = new Provincial("1", Provincial.Franja.Franja_1, 1, "2");
            Provincial provincial2 = new Provincial("1", Provincial.Franja.Franja_1, 1, "2");
            Local local1 = new Local("1", 1, "2", 1);
            Local local2 = new Local("1", 2, "2", 2);
            bool actual1 = false;
            bool actual2 = false;
            bool actual3 = false;
            bool actual4 = false;
            bool excpected1 = true;
            bool excpected2 = true;
            bool excpected3 = false;
            bool excpected4 = false;

            //act
            /* invoca al método en pruebas con los parámetros organizados*/
            actual1 = provincial1 == provincial2;
            actual2 = local1 == local2;
            actual3 = provincial1 == local1;
            actual4 = provincial2 == local2;

            //assert
            /* comprueba si la acción del método en pruebas se comporta de la forma prevista*/
            Assert.AreEqual(excpected1, actual1);
            Assert.AreEqual(excpected2, actual2);
            Assert.AreEqual(excpected3, actual3);
            Assert.AreEqual(excpected4, actual4);

        }
    }
}
