using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballTeam;


namespace FootballPlayerUnitTest
{
    [TestClass]
    public class FootballPlayerTest
    {
        private FootballPlayer footballplayer = new FootballPlayer { Id = 1, Name = "Adi", Age = 20, ShirtNumber = 10 };
        private FootballPlayer footballplayerNameShort = new FootballPlayer { Id = 2, Name = "A", Age = 20, ShirtNumber = 10 };
        private FootballPlayer footballplayerAgeLess = new FootballPlayer { Id = 3, Name = "Adi", Age = 0, ShirtNumber = 10 };       
        private FootballPlayer footballplayerShirtNumberLess = new FootballPlayer { Id = 4, Name = "Adi", Age = 20, ShirtNumber = 0 };
        private FootballPlayer footballplayerShirtNumberBigger = new FootballPlayer { Id = 5, Name = "Adi", Age = 20, ShirtNumber = 100 };

        [TestMethod()]
        public void ToStringTest()
        {
            string str = footballplayer.ToString();   // act
            Assert.AreEqual("1 Adi 20 10", str);  // assert
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            footballplayer.ValidateName();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballplayerNameShort.ValidateName());          
        }
        [TestMethod()]
        public void ValidateAgeTest()
        {
            footballplayer.ValidateAge();        
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballplayerAgeLess.ValidateAge());
        }
        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            footballplayer.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballplayerShirtNumberLess.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballplayerShirtNumberBigger.ValidateShirtNumber());
        }
        [TestMethod()]
        public void ValidateTest()
        {
            footballplayer.Validate();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballplayerNameShort.ValidateName());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballplayerAgeLess.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballplayerShirtNumberLess.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballplayerShirtNumberBigger.Validate());
        }

        [TestMethod()]
        [DataRow(2)]
        [DataRow(100)]
        [DataRow(14593)]

        public void ValidateShirtNumberTest(int ShirtNumber)
        {
            footballplayer.ShirtNumber = ShirtNumber;
            footballplayer.ValidateShirtNumber();
        }
    }
}