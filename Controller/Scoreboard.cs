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
        private List<Score> scores = new List<Score>();
        private DBContext<Score> dB = new DBContext<Score>();


        public List<Score> Scores { get => scores; set => scores = value; }


        public void AddScore(string user, int level, int points)
        {
            Score score = new Score(user, level, points);
            Scores.Add(score);

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
