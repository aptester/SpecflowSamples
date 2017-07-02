using TechTalk.SpecFlow;

namespace xUnitParallel
{
    [Binding]
    public class CalcDivideSteps : CalcSteps
    {
        public CalcDivideSteps(CalcContext calcContext) : base(calcContext)
        {
        }

        [When(@"I press divide")]
        public void WhenIPressDivideAsync()
        {
            Calc.Divide().GetAwaiter().GetResult();
            Output.WriteLine("Divide Complete");
        }
    }
}