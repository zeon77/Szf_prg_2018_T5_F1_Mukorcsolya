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
            List<Eredmény> eredmények = new List<Eredmény>();

            foreach (var line in File.ReadAllLines("rovidprogram.csv").Skip(1))
            {
                eredmények.Add(new Eredmény(line, Eredmény.Szakaszok.Rövid));
            }

            foreach (var line in File.ReadAllLines("donto.csv").Skip(1))
            {
                eredmények.Add(new Eredmény(line, Eredmény.Szakaszok.Döntő));
            }

            //2. feladat
            Console.WriteLine($"2. feladat\n\tA rövidprogramban {eredmények.Where(x => x.Szakasz == Eredmény.Szakaszok.Rövid).Count()} induló volt.");

            //3.
            string s = eredmények.Where(x => x.Szakasz == Eredmény.Szakaszok.Döntő).Any(x => x.Ország == "HUN") ? "bejutott" : "nem jutott be";
            Console.WriteLine($"3. feladat\n\t A magyar versenyző {s} a kűrbe.");

            //5.
            Console.Write($"5. feladat \n\tKérem a versenyző nevét: ");
            string név = Console.ReadLine();
            if (!eredmények.Any(x => x.Név == név))
            {
                Console.WriteLine($"\tIlyen nevű induló nem volt.");
            }
            else
            {
                //6.
                Console.WriteLine($"\tA versenyző összpontszáma: {Eredmény.ÖsszPontszám(név, eredmények)}");
            }

            //7.
            Console.WriteLine($"7. feladat");
            eredmények
                .Where(x => x.Szakasz == Eredmény.Szakaszok.Döntő)
                .GroupBy(x => x.Ország)
                .Select(gr => new { Ország = gr.Key, VersenyzőkSzáma = gr.Count() })
                .Where(x => x.VersenyzőkSzáma > 1)
                .ToList()
                .ForEach(x => Console.WriteLine($"\t{x.Ország}: {x.VersenyzőkSzáma} versenyző"));

            Console.ReadKey();
        }
    }
}
