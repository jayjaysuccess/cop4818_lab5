﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjectsLab2
{
    public class Game
    {
        public string Team1jayjay { get; set; }

        public int Team1Score { get; set; }
        
        public string Team2 { get; set; }

        public int Team2Score { get; set; }


        public Game()
        {

        }

        public Game(string Team1, int Team1Score, string Team2, int Team2Score)
        {

            this.Team1 = Team1;
            this.Team2 = Team2;
            this.Team1Score = Team1Score;
            this.Team2Score = Team2Score;
        }


        public override string ToString()
        {
            return string.Format("{0}, ({1}) - {2}, ({3})", Team1, Team1Score, Team2, Team2Score);

        }
    }
}
