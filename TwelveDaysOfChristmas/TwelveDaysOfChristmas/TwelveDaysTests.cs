using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas
{
    [TestFixture]
    public class TwelveDaysTests
    {
        [Test]
        public void FirstDayOfChristmas_ShouldReturn_PartridgeInAPairTree()
        {
            var tweleveDays = new TwelveDaysofChristmas();
            var song = tweleveDays.Sing(1);
            Assert.AreEqual("a partridge in a pear tree", song);
        }

        [Test]
        public void SecondDayOfChristmas_ShouldReturn_TwoTurtleDoves()
        {
            var tweleveDays = new TwelveDaysofChristmas();
            var song = tweleveDays.Sing(2);
            Assert.AreEqual("Two turtle doves", song);
        }

        [Test]
        public void ThirdDayOfChristmas_ShouldReturn_ThreeFrenchHens()
        {
            var tweleveDays = new TwelveDaysofChristmas();
            var song = tweleveDays.Sing(3);
            Assert.AreEqual("Three french hens", song);
        }

        [Test]
        public void FourthDayOfChristmas_ShouldReturn_FourCallingBirds()
        {
            var tweleveDays = new TwelveDaysofChristmas();
            var song = tweleveDays.Sing(4);
            Assert.AreEqual("Four calling birds", song);
        }
    }

    public class TwelveDaysofChristmas
    {
        private string[] lyrics = new[]
        {
            "a partridge in a pear tree",
            "Two turtle doves",
            "Three french hens"
        };

        public string Sing(int day)
        {
            return lyrics[day - 1];
        }
    }
}
