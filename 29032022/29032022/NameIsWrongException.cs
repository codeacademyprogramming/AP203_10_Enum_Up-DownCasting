using System;
using System.Collections.Generic;
using System.Text;

namespace _29032022
{
    internal class NameIsWrongException:Exception
    {
        public NameIsWrongException(string message):base(message)
        {
        }
    }
}
