using Isogram.app.Services;

namespace Isogram.app;

public class IsogramTest
{
    [Fact]
    public void Shoul_return_true_string_isogram()
    {

        string input = "abcd";
        var repetitiveCharService = new RepetitiveCharService();
        var actual = repetitiveCharService.FindIfIsogram(input);

        Assert.Equal("Isogram", actual);
    }
    [Fact]
    public void Shoul_return_error_string_not_isogram()
    {

        string input = "abcddcc";
        var repetitiveCharService = new RepetitiveCharService();
        var actual = repetitiveCharService.FindIfIsogram(input);

        Assert.Equal("NoIsogram", actual);
    }
}