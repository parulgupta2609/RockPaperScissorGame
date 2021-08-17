using NUnit.Framework;
using System;
namespace RockPaperScissors.Test
{
    [TestFixture()]
    public class HandSignTest
    {
        [Test()]
        public void TestGetWinner()
        {
            Player player1 = new Player("John");
            Player player2 = new Player("CPU");

            player1.HandSign = new HandSign(HandSign.Move.Paper);
            player2.HandSign = new HandSign(HandSign.Move.Rock);

            string expectedMessage = "Congrats!! You are the winner";

            string resultMessage = HandSign.GetWinner(player1, player2);
            Assert.AreEqual(expectedMessage, resultMessage);
        }

        [Test()]
        public void TestGetCPUWinner()
        {
            Player player1 = new Player("John");
            Player player2 = new Player("CPU");

            player1.HandSign = new HandSign(HandSign.Move.Paper);
            player2.HandSign = new HandSign(HandSign.Move.Scissors);

            string expectedMessage = "CPU is the winner";

            string resultMessage = HandSign.GetWinner(player1, player2);
            Assert.AreEqual(expectedMessage, resultMessage);
        }

        [Test()]
        public void TestDraw()
        {
            Player player1 = new Player("John");
            Player player2 = new Player("CPU");

            player1.HandSign = new HandSign(HandSign.Move.Paper);
            player2.HandSign = new HandSign(HandSign.Move.Paper);

            string expectedMessage = "OOPS!! It's a Draw!";

            string resultMessage = HandSign.GetWinner(player1, player2);
            Assert.AreEqual(expectedMessage, resultMessage);
        }

        [Test()]
        public void TestGetWinningMove()
        {
            HandSign.Move move1 = HandSign.Move.Rock;

            string expectedWinningMove = HandSign.Move.Paper.ToString();

            string resultWinningMove = HandSign.GetWinningMove(move1).ToString();
            Assert.AreEqual(expectedWinningMove, resultWinningMove);
        }
    }
}
