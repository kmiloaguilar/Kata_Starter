using Machine.Specifications;

namespace kata.specs
{
    public class given_a_fizzbuzzer_context
    {
        Establish context = () =>
            {
                FizzBuzzer = new FizzBuzzer("fizz", "buzz", 3, 5);
            };

        public static  IFizzBuzzer FizzBuzzer;
    }
}