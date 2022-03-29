using System;
using System.Collections.Generic;
using System.Text;

namespace _29032022
{
    internal class Sheep:Animal
    {
        static int _totalCount;
        public static int TotalCount { get => _totalCount; }
        
        public Sheep(string name):base(name)    
        {
            _totalCount++;
        }
        public string Type { get; set; }

      
    }
}
