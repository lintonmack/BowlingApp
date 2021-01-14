using System.Collections.Generic;

namespace BowlingApp
{
    public class GameManager : IGameManager
    {
        private readonly IGame _game;

        public GameManager(IGame game)
        {
            _game = game;
        }

        public void PerformRoll(IEnumerable<int> rollSequence)
        {
            foreach (var roll in rollSequence)
            {
                _game.Roll(roll);
            }
        }

    }
}