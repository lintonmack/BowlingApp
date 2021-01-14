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
            List<int> frameResult = new List<int>();
            var rollGenerator = _rollGenerator.Generate(10);

            frameResult.Add(rollGenerator);

            if (rollGenerator < 10)
            {
                var newPossibleMaxThrow = 10 - rollGenerator;
                var nextRollGenerator = _rollGenerator.Generate(newPossibleMaxThrow);
                frameResult.Add(nextRollGenerator);
            }

            return frameResult;
        }
    }
}