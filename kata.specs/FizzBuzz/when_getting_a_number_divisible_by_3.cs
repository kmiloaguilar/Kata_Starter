using Machine.Specifications;

namespace kata.specs.FizzBuzz
{
    public class when_getting_a_number_divisible_by_3
    {
        const int Number3 = 3;
        static FizzBuzzer fizzBuzzer;
        static string _result;

        Establish context =
            () => { fizzBuzzer = new FizzBuzzer(); };

        Because of =
            () => _result = fizzBuzzer.Play(Number3);

        It should_return_the_word_fizz =
            () => _result.ShouldEqual("Fizz");
    }
}