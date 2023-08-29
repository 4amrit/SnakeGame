using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classic_Snakes_Game_Tutorial___MOO_ICT
{
    class Score
    {
        List<PlayerScore> Scores;
        string filePath;
        string[] items;

        public Score(string _filepath)
        {
            filePath = _filepath;
            Scores = new List<PlayerScore>();
        }
        public List<PlayerScore> GetAllScores()
        {
            File.ReadAllLines(filePath);

            foreach (var item in File.ReadAllLines(filePath))
            {
                items = item.Split(',');
                if (item.Length < 2) continue;
                Scores.Add(new PlayerScore(items[0], Convert.ToInt16(items[1])));
            }

            return Scores;
        }

    }
}
