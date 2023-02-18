package info.dmerej.calculator;

import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class StepDefinitions {
  private final Calculator calculator = new Calculator();
  private int firstNumber;
  private int secondNumber;
  private int actualSum;

  @Given("First number is {int}")
  public void setFirstNumber(Integer value) {
    this.firstNumber = value;
  }

  @Given("Second number is {int}")
  public void setSecondNumber(Integer value) {
    this.secondNumber = value;
  }

  @When("I add the two numbers")
  public void whenIAdd() {
    actualSum = calculator.add(firstNumber, secondNumber);
  }

  @Then("I get {int}")
  public void setExpected(int expected) {
    assertEquals(actualSum, expected);
  }

}
