using System;
using Xunit;
using Les7;

namespace CoderTest
{
    public class ACoderClassTests
    {
        [Theory]
        [InlineData(1, "Àßàÿ", "ÁÀáà")]
        [InlineData(1, "àÿßÀ", "áàÀÁ")]
         [InlineData(2, "Àßàÿ", "ÂÁâá")]
        [InlineData(2, "1221", "1221")]
        public void ACoder_Encode(int step, string baseString, string result)
        {
            ACoder coder = new ACoder(step);
            Assert.True(coder.Encode(baseString) == result);
        }

        [Theory]
        [InlineData(1, "ÁÀáà", "Àßàÿ")]
        [InlineData(1, "áàÀÁ", "àÿßÀ")]
        [InlineData(2, "ÂÁâá", "Àßàÿ")]
        [InlineData(2, "1221", "1221")]
        public void ACoder_Decode(int step, string baseString, string result)
        {
            ACoder coder = new ACoder(step);
            Assert.True(coder.Decode(baseString) == result);
        }
    }
}
