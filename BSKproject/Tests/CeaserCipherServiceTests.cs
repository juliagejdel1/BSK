using BSKproject.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Tests
{
    public class CeaserCipherServiceTests
    {
        private CeaserCipherService service;

        [SetUp]
        public void SetUp()
        {
            service = new CeaserCipherService();
        }

        [TestCase("CRYPTOGRAPHY", 7, 5, "TURGIZVUFGCR")]
        [TestCase("TestowanieSzyfrow", 7, 5, "IHBIZDFSJHBYROUZD")]
        [TestCase("Kryptografia", 7, 5, "XURGIZVUFOJF")]
        [TestCase("SiecKomputerowa", 7, 5, "BJHTXZLGPIHUZDF")]
        [TestCase("DoZakodowaniaTojestTekst", 7, 5, "AZYFXZAZDFSJFIZQHBIIHXBI")]
        public void EncodeCeaser(string input, int a, int b, string output)
        {
            var result = service.Encode(input, a, b);

            Assert.AreEqual(output, result);

        }
        [TestCase("TURGIZVUFGCR", 7, 5, "CRYPTOGRAPHY")]
        [TestCase("IHBIZDFSJHBYROUZD", 7, 5, "TESTOWANIESZYFROW")]
        [TestCase("XURGIZVUFOJF", 7, 5, "KRYPTOGRAFIA")]
        [TestCase("BJHTXZLGPIHUZDF", 7, 5, "SIECKOMPUTEROWA")]
        [TestCase("AZYFXZAZDFSJFIZQHBIIHXBI", 7, 5, "DOZAKODOWANIATOJESTTEKST")]
        public void DecodeCeaser(string input, int a, int b, string output)
        {
            var result = service.Decode(input, a, b);

            Assert.AreEqual(output, result);


        }
    }
}
