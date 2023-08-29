using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classic_Snakes_Game_Tutorial___MOO_ICT
{
    struct PlayerScore
    {
        public readonly string Name;
        public readonly int Score;

        public PlayerScore(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}
