using TechTalk.SpecFlow;

namespace xUnitParallel
{
    [Binding]
    public class CalcSubtractSteps : CalcSteps
    {
        public CalcSubtractSteps(CalcContext calcContext) : base(calcContext)
        {
        }

        [When(@"I press subtract")]
        public void WhenIPressMinus()
        {
            Calc.Subtract().GetAwaiter().GetResult();
            Output.WriteLine("Subtract Complete");
        }
    }
}