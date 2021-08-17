using System;
namespace RockPaperScissors
{
    public class PrintUtil
    {
        public string GreetOpponent()
        {
            Console.WriteLine("Welcome to the Rock, Paper & Scissors game. It's YOU against the CPU.");
            Console.WriteLine("Let us know your good name, please.");
            string name = Console.ReadLine();
            //Console.WriteLine("{0}, hit the enter key when you are ready to play.", name);
            return name;
        }

        public void StartGameMessage(Player player)
        {
            Console.WriteLine("Ok {0}!! Let's Play the game.\n", player.Name);
        }

        public HandSign ChooseHandSign()
        {
            //Accept user input in various ways
            Console.WriteLine("Make your selection: \n" + 
                              "R-Rock\n" +
                              "P-Paper\n" +
                              "S-Scissors");
            string input = Console.ReadLine();
            var handSign = HandSign.MapStringToMove(input);
            if (handSign == null)
            {
                Console.WriteLine("Invalid selection. Please choose again");
                return ChooseHandSign();
            }
            return handSign;
        }
    }
}


