using System;
using System.Collections.Generic;
using System.Linq;

namespace planet
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////
            ///PLANETS exERcisE ch.4//////////
            /////////////////////////////////

            List<string> planetList = new List<string>
            {    "Mercury" , "Mars" };
            //((1)add() Jupiter and saturn at the end of the list///
            planetList.Add("Jupitur");
            planetList.Add("Saturn");

            Console.WriteLine("planet list");
            planetList.ForEach(planet => Console.WriteLine(planet));

            //(2)create a new list that contains the last two planets of our solar system.

            List<string> planetlist2 = new List<string>() { "Neptune", "Pluto" };

            //(3)Combine the two lists by using `AddRange.

            planetList.AddRange(planetlist2);
            //how to print out list with for loop
            planetList.ForEach(thing => Console.WriteLine
            (thing));

            //(4)  Use `Insert()` to add Earth, and Venus in the correct order.().

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Insert(6, "Uranus");
            Console.WriteLine("after adding earth and venus");




            //(6) Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`. The rocky planets will remain in the original planets list.
            List<string> rockyplanets = planetList.GetRange(0, 4);
            rockyplanets.ForEach(p => Console.WriteLine(p));
            rockyplanets.ForEach(thing => Console.WriteLine
           (thing));

            ///(7)Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.
            planetList.Remove("what ever planet");
         }
    }
}
