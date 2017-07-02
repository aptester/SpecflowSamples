using System.Threading.Tasks;

namespace xUnitParallel
{
    public class Calc
    {
        private decimal _firstNumber;
        private decimal _secondNumber;
        public decimal Result { get; private set; }

        public Calc()
        {
            Result = 0;
        }

        public async Task SetFirstNumber(int firstNumber)
        {
            await Task.Delay(1000);
            _firstNumber = firstNumber;
        }

        public async Task SetSecondNumber(int secondNumber)
        {
            await Task.Delay(1500);
            _secondNumber = secondNumber;
        }

        public async Task Add()
        {
            Result = _firstNumber + _secondNumber;
            await Task.Delay(2000);
        }

        internal async Task Divide()
        {
            await Task.Delay(500);
            Result = _firstNumber / _secondNumber;
        }

        internal async Task Multiply()
        {
            await Task.Delay(200);
            Result = _firstNumber * _secondNumber;
        }

        public async Task Subtract()
        {
            await Task.Delay(600);
            Result = _firstNumber - _secondNumber;
        }
    }
}