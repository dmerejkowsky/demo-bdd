from dataclasses import dataclass
import pytest
from pytest_bdd import scenarios, given, when, then, parsers
from calculator import Calculator
from datetime import datetime

scenarios("features")


@given(
    parsers.parse("First number is {value:d}"),
    target_fixture="first_number",
)
def first_number(value):
    return value


@given(
    parsers.parse("Second number is {value:d}"),
    target_fixture="second_number",
)
def second_number(value):
    return value


@when(
    parsers.parse("I add the two numbers"),
    target_fixture="actual_sum",
)
def actual_sum(first_number, second_number):
    calculator = Calculator()
    return calculator.add(first_number, second_number)


@then(parsers.parse("I get {expected_sum:d}"))
def check_actual_sum(actual_sum, expected_sum):
    assert actual_sum == expected_sum
