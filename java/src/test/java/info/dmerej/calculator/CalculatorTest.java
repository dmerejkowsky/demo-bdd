package info.dmerej.calculator;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class CalculatorTest {

  @Test
  void two_plus_two_is_four() {
    var calculator = new Calculator();
    var actual = calculator.add(2, 2);
    assertEquals(4, actual);
  }
}