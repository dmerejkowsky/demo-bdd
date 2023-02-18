namespace Calculator.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestTwoPlusTwoIsFour()
    {
        var calculator = new Calculator();
        var result = calculator.Add(2, 2);
        Assert.That(result, Is.EqualTo(4));
    }
}