using System;
using System.Collections.Generic;
using System.IO;

namespace KangelasedValjataga
{
    class Program
    {
        static List<Kangelane> kangelased;
        static void LaeKangelased(string failinimi)
        {
            //Console.WriteLine(File.ReadAllText(failinimi));
            var kangelasedFailis = File.ReadAllText(failinimi);
        }
        static void Main(string[] args)
        {
            SuperKangelane supeman = new SuperKangelane("Superman", "Smallville");
            int sajast = supeman.Päästa(100);
            int poolSajast = supeman.Päästa(50);
            Console.WriteLine(supeman.ToString());
            Console.WriteLine($"Sajast:{sajast}");
            Console.WriteLine($"viiekümnest:{poolSajast}");
            LaeKangelased("kangelased.txt");
        }
    }
}
