using System;
using System.Collections.Generic;

namespace SoA
{
    class Program
    {
        static void Main(string[] args)
        {
            Person milko = new Teacher();
            milko.PersonName = "Milko";
            milko.Create();
            milko.Drink(20);
            milko.Smoke = "cigarettes";

            Person alexander = new Student();
            alexander.PersonName = "Alexander";
            alexander.Create();
            alexander.Drink(8);
            alexander.Smoke = "shisha";

            Person borislava = new Teacher();
            borislava.PersonName = "Borislava";
            borislava.Create();
            borislava.Drink(10);
            borislava.Smoke = "cigars";

            Person petya = new Student();
            petya.PersonName = "Petya";
            petya.Create();
            petya.Drink(23);
            petya.Smoke = "pipe";
        }
    }
}