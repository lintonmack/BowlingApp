namespace BowlingApp
{
    public static class ScoreManager
    {
        private static int Score;

        public static int GetScore()
        {
            return Score;
        }

        public static void UpdateScore(int incrementBy)
        {
            Score += incrementBy;
        }

        public static void ResetScore()
        {
            Score = 0;
        }
    }
}