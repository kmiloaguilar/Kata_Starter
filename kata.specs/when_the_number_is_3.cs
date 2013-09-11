using Machine.Specifications;

namespace kata.specs
{
    public class when_the_number_is_3 : given_a_fizzbuzzer_context
    {
        static string _result;

        Because of = () =>
            {
                _result =
                    FizzBuzzer.Play(3);
            };

        It should_return_the_word_fizz = () => { _result.ShouldEqual("fizz"); };
    }
}