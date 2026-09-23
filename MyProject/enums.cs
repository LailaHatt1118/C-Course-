using System;
namespace MyProject
{
    class Program 
    {
         // enum = specail "class" that contains a set of named integer constnats 
        //         Used enums when you have values that you know will not change 
        //         To get the integer value from an item , you must explicitly convert to an in

        static void Main (string [] args )
        {
              Console.WriteLine(Planets.Earth + " is Planet number " +(int)Planets.Earth);
              string name = Planets.Pluto.ToString();
              Console.WriteLine("Planet: " + name);
              int PlanetNumber = (int)Planets.Uranus ;
              Console.WriteLine("Planet Number is : " + PlanetNumber);
              int radius = (int)PlanetsRadius.Earth;
              Console.WriteLine("Radius : " + radius);
              double volume = Volume(PlanetsRadius.Earth);
              Console.WriteLine("Volume : " + volume);
        }
        public static double Volume(PlanetsRadius radius)
        {
              double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
              return volume;
        }
        enum Planets
        {
              venus = 1,
              Earth = 2,
              Mars = 3,
              Saturn = 4,
              Uranus = 5, 
              Neptune = 6, 
              Pluto = 7,
        }
        public enum PlanetsRadius
        {
              venus = 10987,
              Earth = 26543,
              Pluto = 7298,
        }
    }
}