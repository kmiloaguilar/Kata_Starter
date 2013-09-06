using System.Globalization;

namespace kata
{
    public class FizzBuzzStrategy : IGameStrategy
    {
        readonly string _fizzLabel;
        readonly string _buzzLable;
        readonly int _fizzerNumber;
        readonly int _buzzerNumber;

        public FizzBuzzStrategy(string fizzLabel, string buzzLable, int fizzerNumber, int buzzerNumber)
        {
            _fizzLabel = fizzLabel;
            _buzzLable = buzzLable;
            _fizzerNumber = fizzerNumber;
            _buzzerNumber = buzzerNumber;
        }

        public string GetNumberString(int number)
        {
        
            if (IsFizz(number))
            {

                return _fizzLabel;
            }
            return IsBuzz(number) ? _buzzLable : number.ToString(CultureInfo.InvariantCulture);
        }

        bool IsBuzz(int number)
        {
            return IsDivisibleBy(number, _buzzerNumber) || Contains(_buzzerNumber, number);
        }

        bool IsFizz(int number)
        {
            return IsDivisibleBy(number, _fizzerNumber) ||
                   Contains(_fizzerNumber, number);
        }




        bool IsDivisibleBy(int number, int divisor)
        {
            return number % divisor == 0;
        }

        bool Contains(int thisNumber, int inThisNumber)
        {
            return inThisNumber.ToString(CultureInfo.InvariantCulture).Contains(thisNumber.ToString(CultureInfo.InvariantCulture));
        }

    }
}