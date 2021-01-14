using System.Collections.Generic;
using System.Linq;

namespace BowlingApp
{
    public class Game : IGame
    {
        private readonly IScoreManager _scoreManager;
        private int _totalScore;
        private readonly IEnumerable<Frame> _frames;


        public Game(
            IGameManager gameManager)
        {
            _frames = gameManager.SetupFramesForGame();
        }
        public void Roll(int playersRoll)
        {
            _totalScore += playersRoll;
        }

        public int Score()
        {
            return _totalScore;
        }

        public int Play()
        {
            foreach (var frame in _frames)
            {
                _totalScore += 10;
            }

            return Score();
        }

        public List<Frame> GetFrames()
        {
            return _frames.ToList();
        }
    }
    
}