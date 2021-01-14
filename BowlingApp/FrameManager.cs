using System;
using System.Collections.Generic;

namespace BowlingApp
{
    public class FrameManager : IFrameManager
    {
        private readonly IGameManager _gameManager;
        private readonly IRollSequenceGenerator _rollSequenceGenerator;

        private int NumberOfFrames = 10;
        private List<List<int>> FrameResults;


        public FrameManager(
            IGameManager gameManager,
            IRollSequenceGenerator rollSequenceGenerator)
        {
            _gameManager = gameManager;
            _rollSequenceGenerator = rollSequenceGenerator;
        }
        public void Handler()
        {
            for (int i = 0; i < NumberOfFrames; i++)
            {
                PlayFrame();
            }
        }

        private void PlayFrame()
        {
            var rollSequences = _rollSequenceGenerator.Generate();
            _gameManager.PerformRoll(rollSequences);
        }

    }
}