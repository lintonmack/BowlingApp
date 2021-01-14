using System.Collections.Generic;

namespace BowlingApp
{
    public class GameManager : IGameManager
    {
        private readonly IFrameManager _frameManager;

        public GameManager(IFrameManager frameManager)
        {
            _frameManager = frameManager;
        }
        public IEnumerable<Frame> SetupFramesForGame()
        {
            var framesToReturn = new List<Frame>();
            for (int i = 0; i < 10; i++)
            {
                framesToReturn.Add(new Frame(new Player()));
            }

            return framesToReturn;
        }

        public int[] Handler()
        {
            var scores = _frameManager.Handler();
            return 0;
        }
    }
}