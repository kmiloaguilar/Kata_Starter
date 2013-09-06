namespace kata
{
    public class FizzBuzzer
    {
        readonly IGameStrategy _gameStrategy;
        

        public FizzBuzzer(IGameStrategy gameStrategy)
        {
            _gameStrategy = gameStrategy;
        }

        public string Play(int number)
        {
            return _gameStrategy.GetNumberString(number);
        }
    }
}