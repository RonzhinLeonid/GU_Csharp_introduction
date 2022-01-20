using System;
using Xunit;
using Les7;

namespace CoderTest
{
    public class BCoderClassTests
    {
        [Theory]
        [InlineData("ภ฿เÿ", "฿ภÿเ")]
        [InlineData("เÿ฿ภ", "ÿเภ฿")]
        [InlineData("1221", "1221")]
        public void BCoder_Encode(string baseString, string result)
        {
            BCoder coder = new BCoder();
            Assert.True(coder.Encode(baseString) == result);
        }

        [Theory]
        [InlineData("ภ฿เÿ", "฿ภÿเ")]
        [InlineData("เÿ฿ภ", "ÿเภ฿")]
        [InlineData("1221", "1221")]
        public void BCoder_Decode(string baseString, string result)
        {
            BCoder coder = new BCoder();
            Assert.True(coder.Decode(baseString) == result);
        }
    }
}
