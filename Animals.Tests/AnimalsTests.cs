using System.Xml.Linq;
using Animals;

namespace Animals.Tests
{
    public class AnimalsTests
    {
        public void DoEatTest (string View)
        {
            View = "tiger";
            string expected = $"���� �������� ���� {View}, ������� �����!";

            if (View == "Tiger" || View == "tiger" || View == "����" || View == "����")
            {
                Console.WriteLine($"���� �������� ���� {View}, ������� �����!");
            }
            if (View == "Elephant" || View == "elephant" || View == "����" || View == "����")
            {
                Console.WriteLine($"���� �������� ���� {View}, ������� ������!");
            }
            if (View == "Penguin" || View == "penguin" || View == "�������" || View == "�������")
            {
                Console.WriteLine($"���� �������� ���� {View}, ������� �����!");
            }
            Assert.That(View, Is.EqualTo(expected));
        }
    }
}