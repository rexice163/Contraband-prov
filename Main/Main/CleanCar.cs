using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class CleanCar : Car
    {
        int passengers()
        {
            return Generator.Next(4);
        }

        int ContrabandAmount()
        {
            return Generator.Next(0);
        }

        public CleanCar()
        {
        }

    }
}
