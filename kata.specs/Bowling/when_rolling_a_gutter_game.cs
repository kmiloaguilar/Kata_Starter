using System.Collections.Generic;
using Machine.Specifications;

namespace kata.specs.Bowling
{
    public class when_rolling_a_gutter_game 
        : given_a_game_context
    {
        static int _result;

        Establish context = ()
                => Rolls.AddRange(new int[20]);
            
        Because of =
            () => _result = Game.Play(Rolls);

        It should_return_a_score_of_0 =
            () => _result.ShouldEqual(0);

    }
}