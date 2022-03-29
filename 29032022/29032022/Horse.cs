using System;
using System.Collections.Generic;
using System.Text;

namespace _29032022
{
    enum HorseType:byte
    {
        Qarabag,
        Ingilis,
        Ereb
    }

    internal class Horse:Animal
    {
        static int _totalCount;
        public Horse(string name):base(name)    
        {
            _totalCount++;
        }
        public HorseType Sort { get; set; }
        public static int TotalCount { get => _totalCount; }

    }
}
