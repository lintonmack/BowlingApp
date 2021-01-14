using System.Collections.Generic;

namespace BowlingApp
{
    public interface IGame
    {
        void Roll(int playersRoll);
        int Score();
        int GetFrames();
        int Play();
    }
}