using System;
using System.Collections.Generic;

namespace Abstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var Hund = new Hund();
            Hund.Color = "Vit";

            var Katt = new Katt();
            Katt.Color = "Sköldpadda";

            var Chicken = new Chicken();
            Chicken.Color = "Brun";

            animals.Add(Hund);
            animals.Add(Katt);
            animals.Add(Chicken);

            foreach(var animal in animals)
            {
                animal.Breathe();
                animal.Rest();
                animal.Eat();
            }

            List<Accessories> accessory = new List<Accessories>();

            var Foodbowl = new Foodbowl();
            Foodbowl.Material = "Metal";

            var Godis = new Godis();
            Godis.Material = "Fiskrens";

            var Collar = new Collar();
            Collar.Material = "Leather";

            accessory.Add(Foodbowl);
            accessory.Add(Godis);
            accessory.Add(Collar);

            foreach (var accessories in accessory)
            {
                accessories.Sound();
                accessories.Use();
            }
        }
    }
}
