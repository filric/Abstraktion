using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Collar : Accessories
    {
        public Collar()
        {
            Edible = false;
        }
        public override void Sound()
        {
            Console.WriteLine("(Choking sounds)");
        }

        public override void Use()
        {
            Console.WriteLine("Prevent your animal from running away");
        }
    }
}
