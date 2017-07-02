using TechTalk.SpecFlow;
using Xunit;

namespace xUnitParallel
{
    [Binding]
    public class CalcAddSteps : CalcSteps
    {
        public CalcAddSteps(CalcContext calcContext) : base(calcContext)
        {
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int firstNumber)
        {
            //await Task.Delay(1000);
            Calc.SetFirstNumber(firstNumber).GetAwaiter().GetResult();
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int secondNumber)
        {
            Calc.SetSecondNumber(secondNumber).GetAwaiter().GetResult();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Calc.Add().GetAwaiter().GetResult();
            Output.WriteLine("Add Complete");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            Assert.Equal(result, Calc.Result);
        }
    }
}