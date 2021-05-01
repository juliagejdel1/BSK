using BSKproject.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSKproject.Tests
{
    public class MatrixShiftTests
    {
        private MatrixShiftService service;

        [SetUp]
        public void SetUp()
        {
            service = new MatrixShiftService();
        }


        [TestCase("CRYPTOGRAPHY", "YPCTRRAOPGHY")]
        [TestCase("TestowanieSzyfrow", "stToeniweayfSrzow")]
        [TestCase("Kryptografia", "ypKtrraofgia")]
        [TestCase("SiecKomputerowa", "ecSKipuotmowear")]
        [TestCase("DoZakodowaniaTojestTekst", "ZaDkoowoadaTnoistjTestek")]
        public void EncodeMatrixShift(string input, string output)
        {
            var result = service.Encode(input);

            Assert.AreEqual(output, result);

        }
        [TestCase("YPCTRRAOPGHY", "CRYPTOGRAPHY")]
        [TestCase("stToeniweayfSrzow", "TestowanieSzyfrow")]
        [TestCase("ypKtrraofgia", "Kryptografia")]
        [TestCase("ecSKipuotmowear", "SiecKomputerowa")]
        [TestCase("ZaDkoowoadaTnoistjTestek", "DoZakodowaniaTojestTekst")]
        public void DecodeMatrixShift(string input, string output)
        {
            var result = service.Decode(input);

            Assert.AreEqual(output, result);

        }
    }
}
