using System;
using Xunit;
using Les5;

namespace Les5.Tests
{
    public class ComplexTests
    {
        [Fact]
        public void Complex_Equal()
        {
            Complex r1 = new Complex(5, 7);
            Complex r2 = new Complex(5, 7);
            Assert.Equal(r1, r2);
        }

        [Theory]
        [InlineData(5, 9, 5, 10)]
        [InlineData(-1, 10, 1, 10)]
        public void Complex_NotEqual(int reFirst, int imFirst, int reSecond, int imSecond)
        {
            Complex r1 = new Complex(reFirst, imFirst);
            Complex r2 = new Complex(reSecond, imSecond);
            Assert.NotEqual(r1, r2);
        }

        [Theory]
        [InlineData(5, 9, 5, 10, 10, 19)]
        [InlineData(-1, 10, 1, 10, 0, 20)]
        public void Complex_Sum(int reFirst, int imFirst, int reSecond, int imSecond, int reResult, int imResult)
        {
            Complex r1 = new Complex(reFirst, imFirst);
            Complex r2 = new Complex(reSecond, imSecond);
            Complex result = new Complex(reResult, imResult);
            Assert.Equal(r1 + r2, result);
        }

        [Theory]
        [InlineData(5, 9, 5, 10, 0, -1)]
        [InlineData(-1, 10, 1, 10, -2, 0)]
        public void Complex_Subtraction(int reFirst, int imFirst, int reSecond, int imSecond, int reResult, int imResult)
        {
            Complex r1 = new Complex(reFirst, imFirst);
            Complex r2 = new Complex(reSecond, imSecond);
            Complex result = new Complex(reResult, imResult);
            Assert.Equal(r1 - r2, result);
        }

        [Theory]
        [InlineData(5, 9, 5, 10, -65, 95)]
        [InlineData(-1, 10, 1, 10, -101, 0)]
        public void Complex_Multi(int reFirst, int imFirst, int reSecond, int imSecond, int reResult, int imResult)
        {
            Complex r1 = new Complex(reFirst, imFirst);
            Complex r2 = new Complex(reSecond, imSecond);
            Complex result = new Complex(reResult, imResult);
            Assert.Equal(r1 * r2, result);
        }
    }
}
