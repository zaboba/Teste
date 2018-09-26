using System;
using System.Collections.Generic;
using System.IO;

namespace P21Sistemas {
    public class Program {


        public string NOME_PADRAO = "game_";


        static void Main(string[] args) {

            int gameCount = 0;
            List<Game> jogos = new List<Game>();

            jogos = readLogFile(gameCount);

            Console.ReadLine();
        }

        private static List<Game> readLogFile(int gameCount) {
            try {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("C:/Users/Henrique/Desktop/p21Sistemas/games.log")) {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadLine();

                    while (line != null) {
                        if (line.Contains("InitGame")) {

                            Console.WriteLine(line);
                            
                        }
                        line = sr.ReadLine();
                    }
                    
                }
            } catch (Exception e) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return new List<Game>();
        }
    }
}
