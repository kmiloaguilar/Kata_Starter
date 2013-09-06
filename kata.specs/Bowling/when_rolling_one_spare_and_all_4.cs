using Machine.Specifications;

namespace kata.specs.Bowling
{
    public class when_rolling_one_spare_and_all_4 : given_a_game_context
    {
        static int _result;

        Establish context =
            () => Rolls.AddRange(new int[20] {0, 0, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0});

        Because of =
            () => _result = Game.Play(Rolls);

        It should_return_20 =
            () => _result.ShouldEqual(20);
    }
}