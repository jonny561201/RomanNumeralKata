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
            Assert.AreEqual("IV", new RomanNumeralConverter().Convert(4));
            Assert.AreEqual("V", new RomanNumeralConverter().Convert(5));
            Assert.AreEqual("IX", new RomanNumeralConverter().Convert(9));
            Assert.AreEqual("X", new RomanNumeralConverter().Convert(10));
            Assert.AreEqual("L", new RomanNumeralConverter().Convert(50));
            Assert.AreEqual("C", new RomanNumeralConverter().Convert(100));
            Assert.AreEqual("D", new RomanNumeralConverter().Convert(500));
            Assert.AreEqual("M", new RomanNumeralConverter().Convert(1000));
        }
    }
}