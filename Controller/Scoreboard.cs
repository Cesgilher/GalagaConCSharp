using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalagaConC_.Models;

namespace GalagaConC_.Controller
{
    public class Scoreboard
    {
        private List<Score> scores = new();
        private DBContext<Score> dB = new DBContext<Score>();


        public List<Score> GetScores()
        {
            scores = dB.GetAll();
            return scores;
        }
        public void SafeToScoreFile()
        {
            dB.SaveAll(scores);
        }

        public void AddScore(Score score)
        {
            bool allPointsLower = scores
                .Where(s => s.User == score.User)
                .All(s => s.Points < score.Points);

            if (allPointsLower)
            {
                scores.Add(score);
            }

        }

        public void ListScores()
        {
            foreach (Score score in scores)
            {
                Console.WriteLine($"Score: {score.Points}, Level: {score.Level}, User: {score.User} ");

            }

        }
    }
}
