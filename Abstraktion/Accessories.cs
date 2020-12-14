using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
       abstract class Accessories
    {
        public bool Edible { get; set; }

        public string Material { get; set; }

        public abstract void Sound();

        public abstract void Use();

    }
}
