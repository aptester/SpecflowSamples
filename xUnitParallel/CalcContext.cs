using TechTalk.SpecFlow;
using Xunit.Abstractions;

namespace xUnitParallel
{
    public class CalcContext
    {
        public Calc Calc;
        public ITestOutputHelper Output;

        public CalcContext(ScenarioContext context)
        {
            Calc = new Calc();
            Output = context.ScenarioContainer.Resolve<ITestOutputHelper>();
        }
    }
}