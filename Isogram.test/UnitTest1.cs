namespace Isogram.app;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var expected = "Isogram";
        var actual = RepetitiveChar("abcd");

        Assert.Equal(expected, actual);
    }
}