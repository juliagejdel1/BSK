using BSKproject.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Tests
{
    public class VigenereCipherServiceTests
    {
        private VigenereCipherService service;

        [SetUp]
        public void SetUp()
        {
            service = new VigenereCipherService();
        }

        [TestCase("CRYPTOGRAPHY", "BREAK", "DICPDPXVAZIP")]
        [TestCase("TestowanieSzyfrow", "BREAK", "UVWTYXRRIOTQCFBPN")]
        [TestCase("Kryptografia", "BREAK", "LICPDPXVAPJR")]
        [TestCase("SiecKomputerowa", "BREAK", "TZICUPDTUDFISWK")]
        [TestCase("DoZakodowaniaTojestTekst", "BREAK", "EFDAUPUSWKOZETYKVWTDFBWT")]
        public void EncodeVigenere(string input, string key, string output)
        {
            input = input.ToUpper();
            var result = service.Encode(input, key);

            Assert.AreEqual(output, result);

        }

        [TestCase("DICPDPXVAZIP", "BREAK", "CRYPTOGRAPHY")]
        [TestCase("UvwtyxrrioTqcfbpn", "BREAK", "TestowanieSzyfrow")]
        [TestCase("Licpdpxvapjr", "BREAK", "Kryptografia")]
        [TestCase("TzicUpdtudfiswk", "BREAK", "SiecKomputerowa")]
        [TestCase("EfDaupuswkozeTykvwtDfbwt", "BREAK", "DoZakodowaniaTojestTekst")]
        public void DecodeVigenere(string input, string key, string output)
        {
            input = input.ToUpper();
            output = output.ToUpper();
            var result = service.Decode(input, key);

            Assert.AreEqual(output, result);

        }
    }
}
