using System;
using System.Collections.Generic;

namespace BowlingApp
{
    public class FrameManager : IFrameManager
    {
        private readonly IGame _game;
        private readonly IRollGenerator _rollGenerator;
        private int NumberOfFrames = 10;

        public FrameManager(
            IGame game,
            IRollGenerator rollGenerator)
        {
            _game = game;
            _rollGenerator = rollGenerator;
        }
        public int[] Handler()
        {
            var scores = new List<int>();
            for (int i = 0; i < NumberOfFrames; i++)
            {
                var rollGenerator = _rollGenerator.Generate();
                var roll = _game.Roll();
            }
        }
    }
}