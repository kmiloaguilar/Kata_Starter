using Machine.Specifications;

namespace kata.specs.Bowling
{
    public class when_rolling_only_ones : given_a_game_context
    {
        static int _result;

        Establish context = () =>
            {
                for (int i = 0; i < 20; i++)
                    Rolls.Add(1);
            };

        Because of =
            () => _result = Game.Play(Rolls);

        It should_return_20 =
            () => _result.ShouldEqual(20);
    }
}