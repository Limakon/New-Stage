using System;
using System.Collections.Generic;
using System.Text;

namespace New_stage
{
    class IWalking
    {
        public interface IWalking

        {

            public void Walk()

            {

                Console.WriteLine(this + " идет в новую точку");

            }

        }

    }
}

