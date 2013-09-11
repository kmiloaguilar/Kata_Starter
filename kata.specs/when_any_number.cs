using Machine.Specifications;

namespace kata.specs
{
    public class when_any_number : given_a_fizzbuzzer_context
    {
        static string _result;
        Because of = () => { _result = FizzBuzzer.Play(4); };

        It should_return_the_number_in_string_forma = () => { _result.ShouldEqual("4"); };
    }
}