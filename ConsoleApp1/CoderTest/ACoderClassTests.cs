using System;
using Xunit;
using Les7;

namespace CoderTest
{
    public class ACoderClassTests
    {
        [Theory]
        [InlineData(1, "����", "����")]
        [InlineData(1, "����", "����")]
         [InlineData(2, "����", "����")]
        [InlineData(2, "1221", "1221")]
        public void ACoder_Encode(int step, string baseString, string result)
        {
            ACoder coder = new ACoder(step);
            Assert.True(coder.Encode(baseString) == result);
        }

        [Theory]
        [InlineData(1, "����", "����")]
        [InlineData(1, "����", "����")]
        [InlineData(2, "����", "����")]
        [InlineData(2, "1221", "1221")]
        public void ACoder_Decode(int step, string baseString, string result)
        {
            ACoder coder = new ACoder(step);
            Assert.True(coder.Decode(baseString) == result);
        }
    }
}
