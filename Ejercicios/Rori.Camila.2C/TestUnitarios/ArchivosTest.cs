using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace TestUnitarios
{
    [TestClass]
    public class ArchivosTest
    {
        [TestMethod]
        public void XmlGuardarLeer_ShouldMatch()
        {
            //Arrange
            Xml<Planeta> xml = new Xml<Planeta>();
            Planeta planeta1 = new Planeta(1, 1, 1, null);
            Planeta planeta2;
            //Act
            xml.Guardar("Prueba.xml", planeta1);
            xml.Leer("Prueba.xml", out planeta2);

            //Assert
            Assert.AreEqual(planeta1, planeta2);
        }

        [TestMethod]
        public void XmlGuardar_ShouldThrowErrorArchivosException()
        {
            //Arrange
            Xml<Planeta> xml = new Xml<Planeta>();
            Planeta planeta1 = new Planeta(1, 1, 1, null);
            //Act

            //Assert
            Assert.ThrowsException<ErrorArchivosException>(() => xml.Guardar("/", planeta1, System.Text.Encoding.UTF8));
        }

    }
}
