using Machine.Specifications;

namespace kata.specs
{
    public class when_the_number_is_3
    {
        static FizzBuzzer _fizzBuzzer;
        static string _result;
        Establish context = () => { _fizzBuzzer = new FizzBuzzer(); };

        Because of = () => { _result = _fizzBuzzer.Play(3); };

        It should_return_the_word_fizz = () => { _result.ShouldEqual("fizz"); };
    }
}