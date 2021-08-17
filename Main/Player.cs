using System;
namespace RockPaperScissors
{
    public class Player
    {
        private string _name;
        private HandSign _handSign;


        public Player(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public HandSign HandSign
        {
            get { return _handSign; }
            set { _handSign = value; }
        }

    }
}
