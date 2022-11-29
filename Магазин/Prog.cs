using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Prog
    {
        public static void Main(string[] args)
        {
            Store store1 = new Store("Magazin", "Vernadskogo 86", new List<Audio>(), new List<DVD>());
            Audio audio1 = 
                new Audio("Abbey Road", "Rock", "The Beatles", "Apple Records", 40);
            Audio audio2 = 
                new Audio("PHILARMONIA", "Hip-hop", "PHARAOH", "Dead Dynasty", 13);
            store1 = store1 + audio1;
            store1 = store1 + audio2;
            
            DVD dvd1 =
                new DVD("Drive", "Thriller", "Nicolas Winding", "Bold Films", 100);
            DVD dvd2 =
                new DVD("The Big Lebowski", "Comedy", "Joel Coen", "Working Title Films", 117);
            store1 = store1 + dvd1;
            store1 = store1 + dvd2;
            store1.ToString();
            dvd1.Burn("No Country for old men", "Thriller", "Joel Coen", "Scot Rudin Productions", 122);


            store1.AllDisks();

        }
    }
}