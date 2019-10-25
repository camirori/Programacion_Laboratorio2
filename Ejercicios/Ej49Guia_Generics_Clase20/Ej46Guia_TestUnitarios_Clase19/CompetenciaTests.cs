using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej36Guia_Herencia;

namespace Ej46Guia_TestUnitarios_Clase19
{
    [TestClass]
    public class CompetenciaTests
    {
        [TestMethod]    //46.b
        public void CompetidoresListInstanciada()
        {
            //arrange+act
            Competencia<AutoF1> competencia = new Competencia<AutoF1>(1, 1, Competencia<AutoF1>.TipoCompetencia.F1);

            //assert
            Assert.IsNotNull(competencia.Competidores);
        }

        [TestMethod]    //46.c
        public void ThrowCompetenciaNoDisponible()
        {
            //arrange
            Competencia<MotoCross> competencia = new Competencia<MotoCross>(1, 1, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1(1, "1");

            //act+ assert
            //Assert.ThrowsException<CompetenciaNoDisponibleException>(() => competencia + auto); > Error de comp
        }

        //[TestMethod]    //46.d
        //public void NotThrowCompetenciaNoDisponible()
        //{
        //    //arrange
        //    Competencia competencia = new Competencia(1, 1, Competencia.TipoCompetencia.MotoCross);
        //    MotoCross moto = new MotoCross(1, "1");

        //    //act
        //    try
        //    {
        //        bool actual = competencia + moto;
        //    }
        //    catch(Exception)
        //    {
        //        Assert.Fail();
        //    }

        //}

        [TestMethod]    //46.e
        public void CargaVehiculo()
        {
            //arrange
            Competencia<MotoCross> competencia = new Competencia<MotoCross>(1, 1, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "1");
            bool expected = true;

            //act
            bool actual = competencia + moto;
            actual = competencia == moto;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]    //46.d
        public void BorraVehiculo()
        {
            //arrange
            Competencia<MotoCross> competencia = new Competencia<MotoCross>(1, 1, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "1");
            bool expected = false;

            //act
            bool actual = competencia + moto;
            actual = competencia - moto;
            actual = competencia == moto;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
