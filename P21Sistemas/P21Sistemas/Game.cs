using System;
using System.Collections.Generic;
using System.Text;

namespace P21Sistemas {
    public class Game {

        public Game() { }

        public Game(string nome, int totalKills, ICollection<Player> players) {
            Nome = nome;
            Jogadores = players;
            TotalKills = totalKills;
        }

        public string Nome { get; set; }
        public ICollection<Player> Jogadores { get; set; }
        public int TotalKills { get; set; }

    }
}
