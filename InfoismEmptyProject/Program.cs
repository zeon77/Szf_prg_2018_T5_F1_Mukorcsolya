using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InfoismEmptyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RenameThisClass> renameThisList = new List<RenameThisClass>();

            //Modify file name, and check if first line skip is needed.
            foreach (var line in File.ReadAllLines("filename.txt").Skip(1))
            {
                renameThisList.Add(new RenameThisClass(line));
            }

            //3. feladat
            Console.WriteLine($"3. feladat: Sorok száma a fájlban: {renameThisList.Count}");

            //4.

            Console.ReadKey();
        }
    }
}
