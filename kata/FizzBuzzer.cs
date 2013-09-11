namespace kata
{
    public interface IFizzBuzzer
    {
        string Play(int number);
    }

    public class FizzBuzzer : IFizzBuzzer
    {
        readonly string _buzzLabel;
        readonly int _buzzNumber;
        readonly string _fizzLabel;
        readonly int _fizzNumber;

        public FizzBuzzer(string fizzLabel, string buzzLabel, int fizzNumber, int buzzNumber)
        {
            _fizzLabel = fizzLabel;
            _buzzLabel = buzzLabel;
            _fizzNumber = fizzNumber;
            _buzzNumber = buzzNumber;
        }

        public string Play(int number)
        {
            if ((number%_fizzNumber) == 0 && (number%_buzzNumber) == 0)
            {
                return _fizzLabel + _buzzLabel;
            }
            if (number == _fizzNumber || (number%_fizzNumber) == 0)
            {
                return _fizzLabel;
            }
            if (number == _buzzNumber || (number%_buzzNumber) == 0)
            {
                return _buzzLabel;
            }
            return number.ToString();
        }
    }
}