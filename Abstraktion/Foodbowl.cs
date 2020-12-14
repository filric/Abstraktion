using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Foodbowl : Accessories
    {
        public Foodbowl()
        {
            Edible = false;
        }
        public override void Sound()
        {
            Console.WriteLine("(Robot noice)");
        }

        public override void Use()
        {
            Console.WriteLine("Holds your animals food");
        }
    }
}
