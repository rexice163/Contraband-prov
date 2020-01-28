using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Car
    {
        public int passengers;

        public int ContrabandAmount;

        public bool alreadyChecked;

        public Random Generator = new Random();

        public bool Examine()
        {
            if (ContrabandAmount > 0)
            {
                alreadyChecked = true;
                Console.WriteLine("You found " + ContrabandAmount + " goods");
                return true;
            }
            else
            {
                alreadyChecked = true;
                Console.WriteLine("There is nothing here");
                return false;
            }
        }

    }
}
