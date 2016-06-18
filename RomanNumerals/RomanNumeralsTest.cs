namespace RomanNumerals
{

    using NUnit.Framework;

    [TestFixture]
    class RomanNumeralConverterTest
    {

        [Test]
        public void ConvertArabicToRoman()
        {
            Assert.AreEqual("", new RomanNumeralConverter().Convert(0));
            Assert.AreEqual("I", new RomanNumeralConverter().Convert(1));
            Assert.AreEqual("II", new RomanNumeralConverter().Convert(2));
            Assert.AreEqual("III", new RomanNumeralConverter().Convert(3));
            Assert.AreEqual("IV", new RomanNumeralConverter().Convert(4));
            Assert.AreEqual("V", new RomanNumeralConverter().Convert(5));
            Assert.AreEqual("VI", new RomanNumeralConverter().Convert(6));
            Assert.AreEqual("IX", new RomanNumeralConverter().Convert(9));
            Assert.AreEqual("X", new RomanNumeralConverter().Convert(10));
            Assert.AreEqual("XII", new RomanNumeralConverter().Convert(12));
            Assert.AreEqual("XIX", new RomanNumeralConverter().Convert(19));
            Assert.AreEqual("XXV", new RomanNumeralConverter().Convert(25));
            Assert.AreEqual("XL", new RomanNumeralConverter().Convert(40));
            Assert.AreEqual("XLIV", new RomanNumeralConverter().Convert(44));
            Assert.AreEqual("L", new RomanNumeralConverter().Convert(50));
            Assert.AreEqual("XC", new RomanNumeralConverter().Convert(90));
            Assert.AreEqual("C", new RomanNumeralConverter().Convert(100));
            Assert.AreEqual("D", new RomanNumeralConverter().Convert(500));
            Assert.AreEqual("DC", new RomanNumeralConverter().Convert(600));
            Assert.AreEqual("CM", new RomanNumeralConverter().Convert(900));
            Assert.AreEqual("M", new RomanNumeralConverter().Convert(1000));
        }
    }
}
