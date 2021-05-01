using BSKproject.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Tests
{
    public class Matrix2cTests
    {
        private Matrix2cService service;

        [SetUp]
        public void SetUp()
        {
            service = new Matrix2cService();
        }
        [TestCase("CRYPTOGRAPHY", "CONVENIENCE", "CRYHOARPGPYT")]
        [TestCase("TestowanieSzyfrow", "CONVENIENCE", "TezwSwointfaesyor")]
        [TestCase("Kryptografia", "CONVENIENCE", "Kraioarpgfyt")]
        [TestCase("SiecKomputerowa", "CONVENIENCE", "SireoupcwmteoKa")]
        [TestCase("DoZakodowaniaTojestTekst", "CONVENIENCE", "DoienojewtosaTtdkaZaskoT")]
        public void Encode2c(string input, string key, string output)
        {
            var result = service.Encode(input, key);

            Assert.AreEqual(output, result);

        }

        [TestCase("CRYHOARPGPYT", "CONVENIENCE", "CRYPTOGRAPHY")]
        [TestCase("TezwSwointfaesyor", "CONVENIENCE", "TestowanieSzyfrow")]
        [TestCase("Kraioarpgfyt", "CONVENIENCE", "Kryptografia")]
        [TestCase("SireoupcwmteoKa", "CONVENIENCE", "SiecKomputerowa")]
        [TestCase("DoienojewtosaTtdkaZaskoT", "CONVENIENCE", "DoZakodowaniaTojestTekst")]
        public void Decode2c(string input, string key, string output)
        {
            var result = service.Decode(input, key);

            Assert.AreEqual(output, result);

        }

    }
}
