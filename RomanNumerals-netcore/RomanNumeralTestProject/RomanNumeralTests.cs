using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralTestProject
{
    public class Tests
    {
        RomanNumeralsConverter rc;
        [SetUp]
        public void Setup()
        {
           rc = new RomanNumeralsConverter();
        }

        [Test]
        public void Zero_Should_Return_Empty_String()
        {
            var roman = rc.ConvertToRoman(0);
            Assert.AreEqual("", roman);
        }

        [Test]
        public void Valid_Integer_Number_Should_Return_Roman_NumeralCorrectly()
        {
            Assert.AreEqual(expected: "III", rc.ConvertToRoman(3));
            Assert.AreEqual(expected: "V", rc.ConvertToRoman(5));
            Assert.AreEqual(expected: "VI", rc.ConvertToRoman(6));
            Assert.AreEqual(expected: "VIII", rc.ConvertToRoman(8));
        }

        [Test]
        public void Edge_Cases_Should_Return_Valid_Roman_Numerals()
        {
            Assert.AreEqual(expected: "IV", rc.ConvertToRoman(4));
            Assert.AreEqual(expected: "XIX", rc.ConvertToRoman(19));
            Assert.AreEqual(expected: "LXXXIX", rc.ConvertToRoman(89));
            Assert.AreEqual(expected: "XLIX", rc.ConvertToRoman(49));
        }
        [Test]
        public void Non_Positive_Integers_Should_Return_Noting()
        {
            Assert.AreEqual(expected: "", rc.ConvertToRoman(-4));
        }
    }
}