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
    public class ClaseBTests
    {
        [TestMethod()]
        public void ClaseBTest()
        {
            Assert.ThrowsException<UnaException>(() => new ClaseB());
        }
    }
}