using System;
using NUnit.Framework;

namespace romannumbers.tests
{
    [TestFixture]
    public class NumberConversionShould
    {
        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(41, "XLI")]
        [TestCase(44, "XLIV")]
        public void ReturnNumberConvertedToRomanNumber(int number, string romanNumber)
        {
            var converter = new Converter();
            Assert.AreEqual(romanNumber, converter.ConvertToRoman(number));
        }

        [Test]
        public void AddValuesToGetNumber()
        {
            var converter = new Converter();
            Assert.AreEqual("III", converter.ConvertToRoman(3));
        }

        [Test]
        public void ReturnSubstractionIfPreceingValueCanBeSubstracted()
        {
            var converter = new Converter();
            Assert.AreEqual("IV", converter.ConvertToRoman(4));
        }
    }
}
