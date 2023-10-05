using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GalagaConC_
{
    public class Score
    {
        private string user;
        private int level;
        private int points;

        public string User { get => user; set => user = value; }
        public int Level { get => level; set => level = value; }
        public int Points { get => points; set => points = value; }
    }
}
