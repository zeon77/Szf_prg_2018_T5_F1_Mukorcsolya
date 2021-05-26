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

            //3. feladat
            //Console.WriteLine($"3. feladat: Sorok száma a fájlban: {erdemények.Count}");

            //4.

            Console.ReadKey();
        }
    }
}
