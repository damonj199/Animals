using System.Xml.Linq;
using Animals;

namespace Animals.Tests
{
    public class AnimalsTests
    {
        [TestCase("Tiger", "Leo, ������� �����!")]
        [TestCase("tiger", "Leo, ������� �����!")]
        [TestCase("����", "Leo, ������� �����!")]
        [TestCase("����", "Leo, ������� �����!")]
        public void DoEatTest (string View, string expected)
        {
            Animals tiger = new("Leo", 5, 3.5, "Tiger", "Africa", 8.5, "meat", "Ppp-Ppp");

            string actual = tiger.DoEat("Tiger");

            Assert.AreEqual(expected, actual);
        }
    }
}