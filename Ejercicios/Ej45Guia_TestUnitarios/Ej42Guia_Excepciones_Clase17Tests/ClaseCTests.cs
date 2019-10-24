using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej42Guia_Excepciones_Clase17;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42Guia_Excepciones_Clase17.Tests
{
    [TestClass()]
    public class ClaseCTests
    {
        [TestMethod()]
        public void MetodoInstanciaTest()
        {
            //arrange
            ClaseC claseC = new ClaseC();

            //Act+Assert
            Assert.ThrowsException<MiException>(() => claseC.MetodoInstancia());
        }
    }
}