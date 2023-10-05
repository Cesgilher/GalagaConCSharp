using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class Scoreboard
    {
        private Score[] scores;
        private string overlay;

        public Score[] Scores { get => scores; set => scores = value; }
        public string Overlay { get => overlay; set => overlay = value; }


        public void AddScore() { }

        public void ListScores() { }   
    }
}
