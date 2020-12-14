using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Chicken : Animal
    {
        public Chicken()
        {
            NumberOfLimbs = 2;
        }

        public override void Breathe()
        {
            Console.WriteLine("Kluck Kluck");
        }

        public override void Eat()
        {
            Console.WriteLine("Pick Pick");
        }

        public override void Rest()
        {
            Console.WriteLine("Sover på en pinne");
        }
    }
}
