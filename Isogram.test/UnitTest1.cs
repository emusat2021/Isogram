using Isogram.app.Models;

namespace Isogram.app;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var repetitiveCharModel = new RepetitiveCharModel();

        Assert.Equal("Isogra", repetitiveCharModel.Test("abcd"));
    }
}