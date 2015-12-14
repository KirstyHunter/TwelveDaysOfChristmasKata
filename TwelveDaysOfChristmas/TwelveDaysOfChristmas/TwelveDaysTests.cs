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
    }

    public class TwelveDaysofChristmas
    {
        public string Sing(int day)
        {
            if(day == 1)
            {
                return "a partridge in a pear tree";
            }

            return "Two turtle doves";
            
        }
    }
}
