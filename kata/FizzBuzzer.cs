namespace kata
{
    public class FizzBuzzer
    {
        public string Play(int number)
        {
            var numberString = number + "";
            if (number % 3 == 0 || numberString.Contains("3"))
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return numberString;
        }
    }
}