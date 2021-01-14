using System.Collections.Generic;

namespace BowlingApp
{
    public interface IGameManager
    {
        IEnumerable<Frame> SetupFramesForGame();
        int[] Handler();
    }
}