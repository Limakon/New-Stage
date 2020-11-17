using System;
using System.Collections.Generic;
using System.Text;

namespace New_stage
{
    class Dog
    {
        public class Dog : Animal, IWalking

        {

            public string Name

            { get; set; }

            public override string ToString() => Name;

            public Dog(string name, DateTime birthday)

            {

                Name = name;

                Birthday = birthday;

            }

        }
    }
}
