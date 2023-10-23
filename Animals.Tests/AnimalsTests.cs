using System.Xml.Linq;
using Animals;

namespace Animals.Tests
{
    public class AnimalsTests
    {
        public void DoEatTest (string View)
        {
            View = "tiger";
            string expected = $"Всех животных вида {View}, кормить мясом!";

            if (View == "Tiger" || View == "tiger" || View == "Тигр" || View == "тигр")
            {
                Console.WriteLine($"Всех животных вида {View}, кормить мясом!");
            }
            if (View == "Elephant" || View == "elephant" || View == "Слон" || View == "слон")
            {
                Console.WriteLine($"Всех животных вида {View}, кормить травой!");
            }
            if (View == "Penguin" || View == "penguin" || View == "Пингвин" || View == "пингвин")
            {
                Console.WriteLine($"Всех животных вида {View}, кормить рыбой!");
            }
            Assert.That(View, Is.EqualTo(expected));
        }
    }
}