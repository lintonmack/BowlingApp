using System.Collections.Generic;

namespace BowlingApp
{
    public interface IGame
    {
        void Roll(int playersRoll);
        int Score();
        List<Frame> GetFrames();
        int Play();
    }
}