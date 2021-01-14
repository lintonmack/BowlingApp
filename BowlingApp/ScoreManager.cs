namespace BowlingApp
{
    public static class ScoreManager
    {
        private static int _score;

        public static int GetScore()
        {
            return _score;
        }

        public static void UpdateScore(int incrementBy)
        {
            _score += incrementBy;
        }

        public static void ResetScore()
        {
            _score = 0;
        }
    }
}