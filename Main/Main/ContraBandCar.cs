using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class ContraBandCar: Car
    {
        int passengers()
        {
            return Generator.Next(5);
        }

        int ContrabandAmount()
        {
            return Generator.Next(5);
        }

        public ContraBandCar()
        {
        }
    }
}
