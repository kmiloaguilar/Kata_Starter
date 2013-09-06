using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class when_getting_a_number_5 : given_a_fizz_buzzer_context
    {
        static string _result;

        Because of =
            () => _result = FizzBuzzer.Play(5);

        It should_return_the_string_buzz =
            () => _result.ShouldEqual("Buzz");
    }
}