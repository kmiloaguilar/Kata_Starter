using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class give_a_fizz_buzzer_context
    {
        protected static FizzBuzzer FizzBuzzer;

        Establish context =
            () => { FizzBuzzer = new FizzBuzzer(); };
    }
}