using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class when_getting_a_number_divisible_by_3:give_a_fizz_buzzer_context
    {

        static string _result;

        Because of =
            () => _result = FizzBuzzer.Play(9);

        It should_do_something =
            () => _result.ShouldEqual("Fizz");

        
    }
}