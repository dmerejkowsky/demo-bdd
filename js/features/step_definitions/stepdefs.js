const assert = require('assert')
const { Given, When, Then } = require('@cucumber/cucumber')
const Calculator = require('../../index')

Given('First number is {int}', (value) => {
  this.firstNumber = value
})

Given('Second number is {int}', (value) => {
  this.secondNumber = value
})

When('I add the two numbers', () => {
  const { firstNumber, secondNumber } = this

  const calculator = new Calculator()

  this.actualSum = calculator.add(firstNumber, secondNumber)
})

Then('I get {int}', (expectedSum) => {
  assert.equal(this.actualSum, expectedSum)
})
