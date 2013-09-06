using Machine.Specifications;

namespace kata.specs.Bowling
{
    public class when_getting_a_full_house : given_a_game_context
    {
        static int _result;

        Establish context =
            () => Rolls.AddRange(new int[20] {10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 10, 0, 10});

        Because of =
            () => _result = Game.Play(Rolls);

        It should_return_300 =
            () => _result.ShouldEqual(300);
    }
}