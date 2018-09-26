using System;
using System.Collections.Generic;
using System.Text;

namespace P21Sistemas {
    public class Player {

        public Player() { }

        public Player(string nome, int totalKills) {
            Nome = nome;
            TotalKills = totalKills;
        }

        public string Nome { get; set; }
        public int TotalKills { get; set; }
    }
}
