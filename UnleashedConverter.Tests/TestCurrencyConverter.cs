using System;
using Xunit;

namespace UnleashedConverter.Tests
{
    public class TestCurrencyConverter
    {
        [Theory(DisplayName = "Positive Whole Numbers")]
        [InlineData(4, "four dollars")]
        [InlineData(1, "one dollar")] //pluralisation test
        [InlineData((long)2147483648, "two billion one hundred and forty seven million four hundred and eighty three thousand six hundred and forty eight dollars")] //over max int test
        public void TestConvertPositiveWholeNumbers(decimal val, string expectedResult)
        {
            var result = CurrencyConverter.HumanizeCurrency(val);
            Assert.Equal(expectedResult, result);
        }
        [Theory(DisplayName = "Negative Whole Numbers")]
        [InlineData(-6, "minus six dollars")]
        [InlineData(-1, "minus one dollars")] //pluralisation test
        public void TestConvertNegativeNumbers(decimal val, string expectedResult)
        {
            var result = CurrencyConverter.HumanizeCurrency(val);
            Assert.Equal(expectedResult, result);
        }
        [Theory(DisplayName = "Decimal Numbers")]
        [InlineData(6.50, "six dollars and fifty cents")]
        [InlineData(5.01, "five dollars and one cent")] //pluralisation check
        [InlineData(6.50102, "six dollars and fifty cents")] //More than 2dp
        [InlineData(0.96, "zero dollars and ninety six cents")] //zero dollar test
        [InlineData(0, "zero dollars")] //zero dollar zero cents test
        public void TestConvertDecimalNumbers(decimal val, string expectedResult)
        {
            var result = CurrencyConverter.HumanizeCurrency(val);
            Assert.Equal(expectedResult, result);
        }
    }
}
