using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{

    using NUnit.Framework;

    [TestFixture]
    class RomanNumeralConverterTest
    {

        [Test]
        public void ConvertArabicToRoman()
        {
            Assert.AreEqual("", new RomanNumeralConverter().ConvertToRomanNumeral(0));
            Assert.AreEqual("I", new RomanNumeralConverter().ConvertToRomanNumeral(1));
            Assert.AreEqual("II", new RomanNumeralConverter().ConvertToRomanNumeral(2));
            Assert.AreEqual("III", new RomanNumeralConverter().ConvertToRomanNumeral(3));
            Assert.AreEqual("IV", new RomanNumeralConverter().ConvertToRomanNumeral(4));
            Assert.AreEqual("V", new RomanNumeralConverter().ConvertToRomanNumeral(5));
            Assert.AreEqual("VI", new RomanNumeralConverter().ConvertToRomanNumeral(6));
            Assert.AreEqual("IX", new RomanNumeralConverter().ConvertToRomanNumeral(9));
            Assert.AreEqual("X", new RomanNumeralConverter().ConvertToRomanNumeral(10));
            Assert.AreEqual("XII", new RomanNumeralConverter().ConvertToRomanNumeral(12));
            Assert.AreEqual("XIX", new RomanNumeralConverter().ConvertToRomanNumeral(19));
            Assert.AreEqual("XXV", new RomanNumeralConverter().ConvertToRomanNumeral(25));
            Assert.AreEqual("XL", new RomanNumeralConverter().ConvertToRomanNumeral(40));
            Assert.AreEqual("XLIV", new RomanNumeralConverter().ConvertToRomanNumeral(44));
            Assert.AreEqual("L", new RomanNumeralConverter().ConvertToRomanNumeral(50));
            Assert.AreEqual("C", new RomanNumeralConverter().ConvertToRomanNumeral(100));
            Assert.AreEqual("D", new RomanNumeralConverter().ConvertToRomanNumeral(500));
            Assert.AreEqual("DC", new RomanNumeralConverter().ConvertToRomanNumeral(600));
            Assert.AreEqual("CM", new RomanNumeralConverter().ConvertToRomanNumeral(900));
            Assert.AreEqual("M", new RomanNumeralConverter().ConvertToRomanNumeral(1000));
        }
    }
}
