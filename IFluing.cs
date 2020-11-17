using System;
using System.Collections.Generic;
using System.Text;

namespace New_stage
{
    class IFluing
    {
        public interface IFlying

        {

            public void Fly()

            {

                Console.WriteLine(this + " летит в новую точку");

            }

        }
    }
}
