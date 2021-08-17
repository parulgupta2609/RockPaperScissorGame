﻿using System;
namespace RockPaperScissors
{
    public class HandSign
    {
        private readonly Move _move;

        public enum Move
        {
            Rock,
            Paper,
            Scissors
        }

        public HandSign(Move move)
        {
            this._move = move;
        }

        public static HandSign MapStringToMove(string userChoice)
        {
            switch (userChoice.ToUpper())
            {
                case "P":
                    return new HandSign(Move.Paper);
                case "S":
                    return new HandSign(Move.Scissors);
                case "R":
                    return new HandSign(Move.Rock);
            }
            return null;
        }

        public static HandSign MapRandomToMove()
        {
            Random random = new Random();
            int cpuChoice = random.Next(0, 2);

            switch (cpuChoice)
            {
                case 0:
                    return new HandSign(Move.Rock);
                case 1:
                    return new HandSign(Move.Paper);
                case 2:
                    return new HandSign(Move.Scissors);
            }
            return null;
        }

        /// <summary>
        /// Gets the winning move.
        /// </summary>
        /// <returns>The winning move.</returns>
        /// <param name="move">Handsign.</param>
        public static Move GetWinningMove(Move move)
        {
            switch (move)
            {
                case Move.Rock:
                    return Move.Paper;
                case Move.Paper:
                    return Move.Scissors;
                default:
                    return Move.Rock;
            }
        }


        /// <summary>
        /// Gets the winner.
        /// </summary>
        /// <returns>The winner.</returns>
        /// <param name="player1">Handsign player1.</param>
        /// <param name="player2">Handsign player2.</param>
        public static string GetWinner(Player player1, Player player2)
        {
            Console.WriteLine($"You selected {player1.HandSign._move} and CPU selected {player2.HandSign._move}.\n");
            if (GetWinningMove(player1.HandSign._move).Equals(player2.HandSign._move))
            {
                //return player2.HandSign.move; //player 1 loses to player 2
                return player2.Name + " is the winner";
            }
            else if (GetWinningMove(player2.HandSign._move).Equals(player1.HandSign._move))
            {
                //return player1.HandSign.move; //player 2 loses to player 1
                return "Congrats!! You are the winner";
            }
            else
            {
                return "OOPS!! It's a Draw!";
            }
        }
    }
}
