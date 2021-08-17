using System;

namespace RockPaperScissors
{
    public class Game
    {

        private Player _humanPlayer;
        private Player _cpuPlayer;
        private static readonly PrintUtil _printUtil = new PrintUtil();

        public void StartGame(int round)
        {
            if (round == 1)
            {
                var name = _printUtil.GreetOpponent();
                //create players
                this._humanPlayer = new Player(name);
                this._cpuPlayer = new Player("CPU");
            }
            //start game message
            _printUtil.StartGameMessage(_humanPlayer);
            //Get users hand, Note check for valid entry
            var humanHandSign = _printUtil.ChooseHandSign();
            this._humanPlayer.HandSign = humanHandSign;
            //Generate a random hand for computer
            this._cpuPlayer.HandSign = HandSign.MapRandomToMove();
            //compare choices
            //Declare winner
            Console.WriteLine(HandSign.GetWinner(this._humanPlayer, this._cpuPlayer));
        }
    }
}


