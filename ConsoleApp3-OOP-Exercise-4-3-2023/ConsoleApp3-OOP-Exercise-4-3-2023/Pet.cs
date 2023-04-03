using System;

namespace ConsoleApp3_OOP_Exercise_4_3_2023
{
    class Pet : WarmBlood
    {
        public string Sound;

        public Pet(string name, Size size, int mass, string sound)
        {
            Name = name;
            Size = size;
            Mass = mass;

            Sound = sound;
        }

        public override string ToString()
        {
            return $"Cat {Name}, {Size}, {Mass}, {Sound}";
        }
    }
}
