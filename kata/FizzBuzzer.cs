namespace kata
{
    public class FizzBuzzer
    {
        public string Play(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }
            if (number == 5)
            {
                return "Buzz";
            }
            return number + "";
        }
    }
}