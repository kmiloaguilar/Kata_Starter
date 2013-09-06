using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class given_a_fizz_buzzer_context
    {
        protected static FizzBuzzer FizzBuzzer;

        Establish context =
            () => { FizzBuzzer = new FizzBuzzer(new FizzBuzzStrategy("Fizz","Buzz",3,5)); };
    }
}