using System.Collections.Generic;

namespace BowlingApp
{
    public interface IGameManager
    {
        void PerformRoll(IEnumerable<int> rollSequence);
    }
}