using System.Collections.Generic;
using System.Linq;

namespace BowlingApp
{
    public class Game : IGame
    {
        private readonly IFrameManager _frameManager;

        private const int NumberOfFrames = 10;

        public Game(
            IFrameManager frameManager)
        {
            _frameManager = frameManager;
            ScoreManager.ResetScore();
        }
        public void Roll(int playersRoll)
        {
            ScoreManager.UpdateScore(playersRoll);
        }

        public int Score()
        {
            return ScoreManager.GetScore();
        }

        public int Play()
        {
            _frameManager.Handler();

            return Score();
        }

        public int GetFrames()
        {
            return NumberOfFrames;
        }
    }
    
}