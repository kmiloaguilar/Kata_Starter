using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class when_getting_number_divisible_by_5 : given_a_fizz_buzzer_context
    {
        Because of =
            () => _result = FizzBuzzer.Play(10);

        It should_return_the_word_buzz =
            () => _result.ShouldEqual("Buzz");

        static string _result;
    }
}