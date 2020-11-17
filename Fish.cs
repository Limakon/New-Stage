using System;
using System.Collections.Generic;
using System.Text;

namespace New_stage
{
    class Fish
    {
        public class Fish : Animal, ISwimming

        {

            public string Name

            { get; set; }

            public override string ToString() => Name;

            public Fish(string name, DateTime birthday)

            {

                Name = name;

                Birthday = birthday;

            }

        }
    }
}
