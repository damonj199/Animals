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
        public int Weight { get; private set; }

        private const int _minWeight = 30;
        public double Age { get; private set; }

        private const int _minAge = 0;
        public string View { get; set; }
        public string Habitat { get; set; }
        public double Area { get; set; }
        public string Food { get; private set; }
        public string Sound { get; set; }

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
        public void DoEat()
        {
            Console.WriteLine($"{Name}, кушать!");
        }
    }
}
