using System;
using System.Collections.Generic;
using System.Text;

namespace _29032022
{
    internal class Animal
    {
        public Animal(string name)
        {
            this.Name = name;   
        }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
