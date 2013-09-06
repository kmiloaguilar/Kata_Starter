using System.Collections.Generic;
using Machine.Specifications;

namespace kata.specs.Bowling
{
    public class given_a_game_context
    {
        public static Game Game;
        public static List<int> Rolls;

        Establish context =
            () =>
                {
                    Game = new Game();
                    Rolls = new List<int>();
                };
    }
}