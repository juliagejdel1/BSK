using BSKproject.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Tests
{
    public class Matrix2bTests
    {
        private Matrix2bService service;

        [SetUp]
        public void SetUp()
        {
            service = new Matrix2bService();
        }
        [TestCase("CRYPTOGRAPHY", "CONVENIENCE", "CYPTRHGYOARP")]
        [TestCase("TestowanieSzyfrow", "CONVENIENCE", "TzeoonSasfwwieytr")]
        [TestCase("Kryptografia", "CONVENIENCE", "Kaftrigyoarp")]
        [TestCase("SiecKomputerowa", "CONVENIENCE", "SrtKpemewouioca")]
        [TestCase("DoZakodowaniaTojestTekst", "CONVENIENCE", "DisaekjotnkdsZToewToatao")]
        public void EncodeMatrix2b(string input, string key, string output)
        {
            var result = service.Encode(input, key);

            Assert.AreEqual(output, result);

        }

        [TestCase("CYPTRHGYOARP", "CONVENIENCE", "CRYPTOGRAPHY")]
        [TestCase("TzeoonSasfwwieytr", "CONVENIENCE", "TestowanieSzyfrow")]
        [TestCase("Kaftrigyoarp", "CONVENIENCE", "Kryptografia")]
        [TestCase("SrtKpemewouioca", "CONVENIENCE", "SiecKomputerowa")]
        [TestCase("DisaekjotnkdsZToewToatao", "CONVENIENCE", "DoZakodowaniaTojestTekst")]
        public void DecodeMatrix2b(string input, string key, string output)
        {
            var result = service.Decode(input, key);

            Assert.AreEqual(output, result);

        }

    }
}
