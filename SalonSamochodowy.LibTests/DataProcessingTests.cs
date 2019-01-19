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
        }
    }
}