using System;
using Xunit;
using Les5;

namespace Les5.Tests
{
    public class RationalNumberTests
    {
        [Theory]
        [InlineData(15, 30, 1, 2)]
        [InlineData(-1, 10, -1, 10)]
        [InlineData(2, -4, -1, 2)]
        public void RationalNumber_IsCorrect(int numerator, int denominator, int numeratorResult, int denominatorResult)
        {
            RationalNumber r = new RationalNumber(numerator, denominator);
            Assert.True(r.Numerator == numeratorResult && r.Denominator == denominatorResult);
        }

        [Fact]
        public void RationalNumber_Exception()
        {
            Assert.Throws<Exception>(() => new RationalNumber(10, 0));
        }


        [Fact]
        public void RationalNumber_Equal()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.Equal(r1, r2);
        }

        [Theory]
        [InlineData(5, 9, 5, 10)]
        [InlineData(-1, 10, 1, 10)]
        public void RationalNumber_NotEqual(int numeratorFirst, int denominatorFirst, int numeratorSecond, int denominatorSecond)
        {
            RationalNumber r1 = new RationalNumber(numeratorFirst, denominatorFirst);
            RationalNumber r2 = new RationalNumber(numeratorSecond, denominatorSecond);
            Assert.NotEqual(r1, r2);
        }

        [Fact]
        public void RationalNumber_True()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(5, 9);
            Assert.True(r1 > r2);
        }

        [Fact]
        public void RationalNumber_False()
        {
            RationalNumber r1 = new RationalNumber(5, 9);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.False(r1 > r2);
        }

        [Fact]
        public void RationalNumber_LessTrue()
        {
            RationalNumber r1 = new RationalNumber(1, 7);
            RationalNumber r2 = new RationalNumber(5, 7);
            Assert.True(r1 < r2);
        }

        [Fact]
        public void RationalNumber_LessFalse()
        {
            RationalNumber r1 = new RationalNumber(5, 7);
            RationalNumber r2 = new RationalNumber(1, 7);
            Assert.False(r1 < r2);
        }


        [Theory]
        [InlineData(5, 9, 4, 9)]
        [InlineData(5, 10, 5, 10)]
        public void RationalNumber_MoreOrEqualTrue(int numeratorFirst, int denominatorFirst, int numeratorSecond, int denominatorSecond)
        {
            RationalNumber r1 = new RationalNumber(numeratorFirst, denominatorFirst);
            RationalNumber r2 = new RationalNumber(numeratorSecond, denominatorSecond);
            Assert.True(r1 >= r2);
        }

        [Theory]
        [InlineData(4, 9, 5, 9)]
        [InlineData(5, 10, 5, 10)]
        public void RationalNumber_LessOrEqualTrue_Less(int numeratorFirst, int denominatorFirst, int numeratorSecond, int denominatorSecond)
        {
            RationalNumber r1 = new RationalNumber(numeratorFirst, denominatorFirst);
            RationalNumber r2 = new RationalNumber(numeratorSecond, denominatorSecond);
            Assert.True(r1 <= r2);
        }

        [Fact]
        public void RationalNumber_ConvertToFloatTrue()
        {
            float a = (float)2 / 7;
            RationalNumber r = new RationalNumber(2, 7);
            Assert.True(a == r);
        }

        [Fact]
        public void RationalNumber_ConvertToFloatFalse()
        {
            float a = (float)2 / 7;
            RationalNumber r = new RationalNumber(2, 9);
            Assert.False(a == r);
        }

        [Fact]
        public void RationalNumber_ConvertToIntTrue()
        {
            int a = 295 / 14;
            RationalNumber r = new RationalNumber(295, 14);
            Assert.True(a == r);
        }

        [Fact]
        public void RationalNumber_ConvertToIntFalse()
        {
            int a = 295 / 14;
            RationalNumber r = new RationalNumber(123, 517);
            Assert.False(a == r);
        }

        [Fact]
        public void RationalNumber_ConvertIntToRationalNumber()
        {
            int a = 295;
            RationalNumber r = (RationalNumber)a;
            Assert.True(r.Numerator == 295 && r.Denominator == 1);
        }
    }
}
