using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Helsinki2017
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Eredmény> erdemények = new List<Eredmény>();

            foreach (var line in File.ReadAllLines("rovidprogram.csv").Skip(1))
            {
                erdemények.Add(new Eredmény(line, "rovid"));
            }

            foreach (var line in File.ReadAllLines("donto.csv").Skip(1))
            {
                erdemények.Add(new Eredmény(line, "donto"));
            }

            //2. feladat
            Console.WriteLine($"2. feladat\n\tA rövidprogramban {erdemények.Where(x => x.Szakasz == "rovid").Count()} induló volt.");

            Console.ReadKey();
        }
    }
}
