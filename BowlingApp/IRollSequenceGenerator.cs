using System.Collections.Generic;

namespace BowlingApp
{
    public interface IRollSequenceGenerator
    {
        List<int> Generate();
    }
}