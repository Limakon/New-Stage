using System;
using System.Collections.Generic;
using System.Text;

namespace New_stage
{
   public class Animal
    {
        public class Animal

        {

            public Animal()

            {

            }

            public DateTime Birthday

            { get; set; }

            public int Age

            { get { return (int)DateTime.Now.Subtract(Birthday).TotalDays / 365; } }

        }

    }
}

