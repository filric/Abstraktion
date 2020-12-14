using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Godis : Accessories
    {
        public Godis()
        {
            Edible = true;
        }

        public override void Sound()
        {
            Console.WriteLine("(Godis ljud)");
        }

        public override void Use()
        {
            Console.WriteLine("Make animal do tricks");
        }
    }
}
