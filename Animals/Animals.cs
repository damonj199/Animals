using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animals
    {
        public string Name { get; set; }
        public string View { get; set; }
        public string Habitat { get; set; }
        public double Area { get; set; }
        public string Sound { get; set; }
        public int Weight { get; private set; }
        private const int _minWeight = 30;
        public double Age { get; private set; }
        private const int _minAge = 0;
        public string Food { get; private set; }

        public Animals(string name, int weihgt, double age, string view, string habitat, double area, string food, string sound) 
        {
            Name = name;
            if (weihgt < _minWeight)
            {
                Weight = weihgt;
            }
            else
            {
                Weight = _minWeight;
            }

            if (age <= _minAge)
            {
                Age = age;
            }
            else
            {
                Age = _minAge;
            }
            View = view;
            Habitat = habitat;
            Area = area;
            Food = food;
            Sound = sound;
        }

        public void DoVoice()
        {
            Console.WriteLine($"{Name}, Pppp-Ppp");
        }
        public void Play()
        {
            Console.WriteLine($"{Name}, ирать!!!");
        }
        public string DoEat(string View)
        {
            string result = "";
            if (View == "Tiger" || View == "tiger" || View == "Тигр" || View == "тигр")
            {

            result = ($"{Name}, кормить мясом!");
            }
            if(View == "Elephant" || View == "elephant" || View == "Слон" || View == "слон")
            {
                result = ($"{Name}, кормить травой!");
            }
            if(View == "Penguin" || View == "penguin" || View == "Пингвин" || View == "пингвин")
            {
                result = ($"{Name}, кормить рыбой!");
            }
            return result;
        }
    }
}
