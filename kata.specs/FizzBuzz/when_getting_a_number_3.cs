using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class when_getting_a_number_3 : give_a_fizz_buzzer_context
    {
        const int Number3 = 3;
        static string _result;

        Because of =
            () => _result = FizzBuzzer.Play(Number3);

        It should_return_the_word_fizz =
            () => _result.ShouldEqual("Fizz");
    }
}