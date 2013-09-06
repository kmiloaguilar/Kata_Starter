using System.Collections.Generic;

namespace kata.specs.Bowling
{
    public class Game
    {
        public int Play(List<int> gameScore)
        {
            int sum = 0;

            for (int frame = 0; frame < 20; frame += 2)
            {
                int roll1 = gameScore[frame];
                int roll2 = gameScore[frame + 1];

                if ((roll1 == 10) && (frame < 17))
                {
                    sum += gameScore[frame] + gameScore[frame + 2] + gameScore[frame + 3];
                }
                else sum += frame;

                if (roll1 + roll2 == 10)
                {
                    if (frame > 0)
                    {
                        sum += 10 + gameScore[frame + 1];
                    }
                    else
                    {
                        sum += 10;
                    }
                }
                else
                {
                    sum += roll1 + roll2;
                }
            }
            return sum;
        }
    }
}