using Isogram.app.Models;

namespace Isogram.app;

public class UnitTest1
{
    [Fact]
    public void Shoul_return_true_string_isogram()
    {

        string input = "abcd";
        var repetitiveCharModel = new RepetitiveCharModel();
        var actual = repetitiveCharModel.FindIfIsogram(input);

        Assert.Equal("Isogram", actual);
    }
    [Fact]
    public void Shoul_return_error_string_not_isogram()
    {

        string input = "abcddcc";
        var repetitiveCharModel = new RepetitiveCharModel();
        var actual = repetitiveCharModel.FindIfIsogram(input);

        Assert.Equal("NoIsogram", actual);
    }
}