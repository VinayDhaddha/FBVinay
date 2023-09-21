using MyApplication;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        Calculator calc = new Calculator();
        int num1, num2, output;
        [Given(@"First number is (.*)")]
        public void GivenFirstNumberIs(int n1)
        {
            num1 = n1;
        }

        [Given(@"then second number is (.*)")]
        public void GivenThenSecondNumberIs(int n2)
        {
            num2 = n2;
        }

        [When(@"the two methods are added")]
        public void WhenTheTwoMethodsAreAdded()
        {
            output = calc.AddNumber(num1, num1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            // Console.WriteLine($"{output}: and the o/p value is {p0}");
            Assert.AreEqual(expected, output);
        }
    }
}
