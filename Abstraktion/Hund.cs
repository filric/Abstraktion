using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Hund : Animal
    {
        public Hund()
        {
            NumberOfLimbs = 4;
        }

        public override void Breathe()
        {
            Console.WriteLine("Flämt Flämt");
        }

        public override void Rest()
        {
            Console.WriteLine("Hunden sover, Hunden sover, i sitt lilla hörn");
        }

        public override void Eat()
        {
            Console.WriteLine("Glufs Glufs OMNOMNOM");
        }
    }
}
