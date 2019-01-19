using SalonSamochodowy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSamochodowy.Tests
{
    [TestClass()]
    public class DataProcessingTests
    {
        [TestMethod()]
        public void PobierzSamochodZNajwiekszymWyposazeniemTest()
        {
            List<Samochod> auta = Dane.Dane.Samochody;

            DataProcessing dp = new DataProcessing();

            Samochod iloscWyposarzenia = dp.PobierzSamochodZNajwiekszymWyposazeniem(auta);
            Assert.AreEqual(6, iloscWyposarzenia.ListaWyposazenia.Count);
        }

        [TestMethod()]
        public void PobierzSamochodNajdrozszyTest()
        {
            List<Samochod> auta = Dane.Dane.Samochody;

            DataProcessing dp = new DataProcessing();

            Samochod wartosc = dp.PobierzSamochodNajdrozszy(auta);
            Assert.AreEqual(50000, wartosc.CenaBazowa);
        }

        //[TestMethod()]
        //public void PosortujPoCenieTest()
        //{
        //    List<Samochod> auta = Dane.Dane.Samochody;
        //    DataProcessing dp = new DataProcessing();

        //    List<Samochod> posortowanaListaAut = dp.PosortujPoCenie(auta);

        //    List<Samochod> doPorownania = new List<Samochod>() { 50000, { 140, Pojemnosc = 1398, Turbo = true }, Model = "A1", RokProdukcji = 2018, SpalanieSrednie = 6.1 }
        //}
    }
}