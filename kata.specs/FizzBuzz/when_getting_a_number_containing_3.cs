using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class when_getting_a_number_containing_3:given_a_fizz_buzzer_context
    {
        static string _result;
        Because of =
            () => _result = FizzBuzzer.Play(13);

        It should_return_string_fizz =
            () => _result.ShouldEqual("Fizz");

        
    }
}