using S4._2.Graphs.Library;

using System;

namespace S4._2.Graphs.ConsoleApp
{
    class Program
    {
        static void Main()
        {

            Vertex<string> kastrup = new("Kastrup");
            Vertex<string> tirstrup = new("Tirstrup");
            Vertex<string> ronne = new("Ronne");
            Vertex<string> aalborg = new("Aalborg");
            Vertex<string> billund = new("Billund");
            Vertex<string> odense = new("Odense");

            billund.AddNeighbour(aalborg);
            billund.AddNeighbour(kastrup);

            kastrup.AddNeighbour(aalborg);
            kastrup.AddNeighbour(tirstrup);
            kastrup.AddNeighbour(ronne);
            kastrup.AddNeighbour(billund);

            aalborg.AddNeighbour(ronne);
            aalborg.AddNeighbour(billund);
            aalborg.AddNeighbour(odense);

            Console.WriteLine(aalborg.ToString());
           
        }
    }
}
