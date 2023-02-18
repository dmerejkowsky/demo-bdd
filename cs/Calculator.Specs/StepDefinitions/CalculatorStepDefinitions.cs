using NUnit.Framework;
using Shouldly;

namespace Calculator.Specs.StepDefinitions;


[Binding]
public sealed class CalculatorStepDefinitions
{
    private readonly Calculator _calculator = new Calculator();
    private int? _firstNumber = null;
    private int? _secondNumber = null;
    private int? _actual = null;



    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _firstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _secondNumber = number;
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        if (_firstNumber == null)
        {
            throw new AssertionException("first number should be set - did you forget a Given step?");
        }
        if (_secondNumber == null)
        {
            throw new AssertionException("second number should be set - did you forget a Given step?");
        }
        _actual = _calculator.Add(_firstNumber.Value, _secondNumber.Value);
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int expected)
    {
        if (_actual == null)
        {
            throw new AssertionException("_actual is not set - did you forget to write a When step?");
        }

        _actual.ShouldBe(expected);
    }
}