using TechTalk.SpecFlow;

namespace xUnitParallel
{
    [Binding]
    public class CalcMultiplySteps : CalcSteps
    {
        public CalcMultiplySteps(CalcContext calcContext) : base(calcContext)
        {
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            Calc.Multiply().GetAwaiter().GetResult();
            Output.WriteLine("Multiply Complete");
        }
    }
}