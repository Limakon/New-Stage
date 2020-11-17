using System;
using System.Collections.Generic;
using System.Text;

namespace New_stage
{
    class Bird
    {
        public class Bird : Animal, IFlying

        {

            public string Name

            { get; set; }

            public override string ToString() => Name;

            public Bird(string name, DateTime birthday)

            {

                Name = name;

                Birthday = birthday;

            }

        }
    }
}
