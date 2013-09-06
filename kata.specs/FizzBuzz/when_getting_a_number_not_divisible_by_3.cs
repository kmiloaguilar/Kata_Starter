using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class when_getting_a_number_not_divisible_by_3:given_a_fizz_buzzer_context
    {

        static string _result;

        Because of =
            () => _result = FizzBuzzer.Play(2);

        It should_return_the_same_number_in_string =
            () => _result.ShouldEqual("2");

    }
}