using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class Scoreboard
    {
        private List<Score> scores = new List<Score>();
        private string overlay;

        public List<Score> Scores { get => scores; set => scores = value; }
        public string Overlay { get => overlay; set => overlay = value; }


        public void AddScore(string user, int level , int points) 
        {   
            Score score = new Score(user, level, points);
            this.Scores.Add(score);
        
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
