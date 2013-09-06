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
            return number + "";
        }
    }
}