namespace MyLibraryTests;

public class UnitTest1
{
    public object? Assert { get; private set; }

    [Fact]
    public void ShouldReturnHelloWorldThreeTimes()
    {
        const string expected = @"Hello World
Hello World
Hello World";
        var sut = new HelloWorldPrinter();

        var str = sut.GetHellWorld(3);

        Assert.Equals(expected, str);
    }
}

internal class FactAttribute : Attribute
{
}