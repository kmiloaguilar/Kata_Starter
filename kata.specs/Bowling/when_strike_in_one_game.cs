using Machine.Specifications;

namespace kata.specs.Bowling
{
    public class when_strike_in_one_game : given_a_game_context
    {
        static int _result;

        Establish context =
            () => Rolls.AddRange(new int[20] {10, 0, 5, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0});

        Because of =
            () => _result = Game.Play(Rolls);

        It should_28 =
            () => _result.ShouldEqual(28);
    }
}