using Machine.Specifications;

namespace kata.specs
{
    public class when_number_is_divisible_by_3 : given_a_fizzbuzzer_context
    {

        Because of = () => { _result = FizzBuzzer.Play(9); };

        It should_return_the_word_fizz = () => { _result.ShouldEqual("fizz"); };
        static string _result;
    }
}