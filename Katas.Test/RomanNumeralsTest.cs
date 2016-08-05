using Xunit;
using Katas;

namespace KatasTest {
    public class RomanNumeralsTest {
        private RomanNumerals _subject;

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(19, "XIX")]
        [InlineData(27, "XXVII")]
        [InlineData(49, "XLIX")]
        [InlineData(57, "LVII")]
        [InlineData(99, "XCIX")]
        [InlineData(201, "CCI")]
        public void RomanTest(int input, string expected) {
            _subject = new RomanNumerals();

            var result = _subject.Convert(input);

            Assert.Equal(expected, result);
        }
    }
}