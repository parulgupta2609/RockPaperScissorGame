using NUnit.Framework;
namespace RockPaperScissors.Test
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void TestPlayerNameCase()
        {
            string expected = "John";
            Player player = new Player("John");
            string playerName = player.Name;
            Assert.AreEqual(expected, playerName);
        }
    }
}
