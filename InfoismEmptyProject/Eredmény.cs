using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helsinki2017
{
    class Eredmény
    {
        public enum Szakaszok
        {
            Rövid,
            Döntő
        }
        public string Név { get; set; }
        public string Ország { get; set; }
        public Szakaszok Szakasz { get; set; }
        public double Technikai { get; set; }
        public double Komponens { get; set; }
        public double Levonás { get; set; }

        public Eredmény(string line, Szakaszok szakasz)
        {
            var decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string[] lineSplitted = line.Split(';');
            Név = lineSplitted[0];
            Ország = lineSplitted[1];
            Szakasz = szakasz;
            Technikai = double.Parse(lineSplitted[2].Replace('.', ','));
            Komponens = double.Parse(lineSplitted[3].Replace('.', ','));
            Levonás = double.Parse(lineSplitted[4].Replace('.', ','));
        }

        //4.
        public static double ÖsszPontszám(string név, List<Eredmény> e)
        {
            return e.Where(x => x.Név == név)
                    .Sum(x => x.Technikai + x.Komponens - x.Levonás);
        }
    }
}
