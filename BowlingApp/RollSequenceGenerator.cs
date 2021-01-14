using System.Collections.Generic;

namespace BowlingApp
{
    public class RollSequenceGenerator : IRollSequenceGenerator
    {
        private readonly IRollGenerator _rollGenerator;

        public RollSequenceGenerator(IRollGenerator rollGenerator)
        {
            _rollGenerator = rollGenerator;
        }

        public List<int> Generate()
        {
            List<int> FrameResult = new List<int>();
            var rollGenerator = _rollGenerator.Generate(10);

            FrameResult.Add(rollGenerator);

            if (rollGenerator < 10)
            {
                var newPossibleMaxThrow = 10 - rollGenerator;
                var nextRollGenerator = _rollGenerator.Generate(newPossibleMaxThrow);
                FrameResult.Add(nextRollGenerator);
            }

            return FrameResult;
        }
    }
}