namespace ChatGPT4TestTest
{
    public class PlayerAnalyzerTests
    {
        [Fact]
        public void NormalPlayerTest()
        {
            var player = new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } };
            var analyzer = new PlayerAnalyzer();
            var score = analyzer.CalculateScore(new List<Player> { player });
            Assert.Equal(250, score);
        }

        [Fact]
        public void JuniorPlayerTest()
        {
            var player = new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } };
            var analyzer = new PlayerAnalyzer();
            var score = analyzer.CalculateScore(new List<Player> { player });
            Assert.Equal(67.5, score);
        }

        [Fact]
        public void SeniorPlayerTest()
        {
            var player = new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } };
            var analyzer = new PlayerAnalyzer();
            var score = analyzer.CalculateScore(new List<Player> { player });
            Assert.Equal(2520, score);
        }

        [Fact]
        public void MultiplePlayersTest()
        {
            var player1 = new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } };
            var player2 = new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } };
            var analyzer = new PlayerAnalyzer();
            var score = analyzer.CalculateScore(new List<Player> { player1, player2 });
            Assert.Equal(2770, score); // 250 from player1 and 2520 from player2
        }

        [Fact]
        public void SkillsIsNullTest()
        {
            var player = new Player { Age = 25, Experience = 5, Skills = null };
            var analyzer = new PlayerAnalyzer();
            Assert.Throws<NullReferenceException>(() => analyzer.CalculateScore(new List<Player> { player }));
        }

        [Fact]
        public void EmptyArrayTest()
        {
            var analyzer = new PlayerAnalyzer();
            var score = analyzer.CalculateScore(new List<Player>());
            Assert.Equal(0, score);
        }
    }
}
