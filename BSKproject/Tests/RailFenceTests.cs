using BSKproject.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Tests
{
    public class RailFenceTests
    {
        private RailFenceService service;

        [SetUp]
        public void SetUp()
        {
            service = new RailFenceService();
        }


        [TestCase("CRYPTOGRAPHY", 3, "CTARPORPYYGH")]
        [TestCase("TestowanieSzyfrow", 5, "TiweneosaSrtwzfoy")]
        [TestCase("Kryptografia", 8, "Krypatiofgar")]
        [TestCase("SiecKomputerowa", 4, "SmoioprweKueact")]
        [TestCase("DoZakodowaniaTojestTekst", 7, "DaoiTtZnosaajkkweeoosTdt")]
        public void EncodeRailFence(string input, int a,  string output)
        {
            var result = service.Encode(input, a);

            Assert.AreEqual(output, result);

        }

        [TestCase("CTARPORPYYGH", 3, "CRYPTOGRAPHY")]
        [TestCase("TiweneosaSrtwzfoy", 5, "TestowanieSzyfrow")]
        [TestCase("Krypatiofgar", 8, "Kryptografia")]
        [TestCase("SmoioprweKueact", 4, "SiecKomputerowa")]
        [TestCase("DaoiTtZnosaajkkweeoosTdt", 7, "DoZakodowaniaTojestTekst")]

        public void DecodeRailFence(string input, int a, string output)
        {
            var result = service.Decode(input, a );

            Assert.AreEqual(output, result);


        }
    }
}
