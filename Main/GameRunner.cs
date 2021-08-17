using System;

namespace RockPaperScissors
{
    class MainClass
    {
        public static void Main()
        {
            Game game = new Game();

            bool gameLoop = true;
            int round = 1;
            while (gameLoop)
            {
                game.StartGame(round);

                Console.WriteLine("Enter Y to keep playing.. \n" +
                                  "Enter N if you wish to stop.");
                string wishToPlayAgain = Console.ReadLine();
                if (!string.IsNullOrEmpty(wishToPlayAgain) && wishToPlayAgain.ToUpper() == "N")
                {
                    gameLoop = false;
                }
                round++;
            }
        }
    }
}


