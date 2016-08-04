using Xunit;

public class RomanNumeralsTest {
    private RomanNumerals _subject;

    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(4, "IV")]
    [InlineData(9, "IX")]
    [InlineData(19, "XIX")]
    [InlineData(27, "XXVII")]
    public void RomanTest(int input, string expected) {
        _subject = new RomanNumerals();

        var result = _subject.Convert(input);

        Assert.Equal(expected, result);
    }
}