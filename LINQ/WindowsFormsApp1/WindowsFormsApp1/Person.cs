using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Person
    {
        public string Family { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public Person(string family, string name, string otchestvo, int age, int weight)
        {
            Family = family;
            Name = name;
            Otchestvo = otchestvo;
            Age = age;
            Weight = weight;
        }
        public string GetInfo()
        {
            return $"{Family} {Name} {Otchestvo} {Age} {Weight}";
        }
    }
}
