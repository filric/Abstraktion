using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Katt : Animal
    {
        public Katt()
        {
            NumberOfLimbs = 4;
        }
        public override void Breathe()
        {
            Console.WriteLine("Purr Purr Purr");
        }

        public override void Rest()
        {
            Console.WriteLine("Katten sover zzzzzzzzzzzzzzz");
        }

        public override void Eat()
        {
            Console.WriteLine("Crunch Crunch Kycklingben");
        }
    }
}
