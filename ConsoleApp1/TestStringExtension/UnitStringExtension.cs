using System;
using Xunit;
using Les3Ex2;

namespace TestStringExtension
{
    public class UnitStringExtension
    {
        [Theory]
        [InlineData("123456", "654321")]
        [InlineData("654321", "123456")]
        [InlineData("13579", "97531")]
        public void ReverseByStringBuilder_IsCorrect(string str, string result)
        {
            Assert.Equal(result, str.ReverseByStringBuilder());
        }

        [Theory]
        [InlineData("123456", "654321")]
        [InlineData("654321", "123456")]
        [InlineData("13579", "97531")]
        public void ReverseByArray_IsCorrect(string str, string result)
        {
            Assert.Equal(result, str.ReverseByArray());
        }

        [Theory]
        [InlineData("123456", "654321")]
        [InlineData("654321", "123456")]
        [InlineData("13579", "97531")]
        public void ReverseByLINQ_IsCorrect(string str, string result)
        {
            Assert.Equal(result, str.ReverseByLINQ());
        }
    }
}