using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoismEmptyProject
{
    class RenameThisClass
    {
        //give corresponding names to properties
        public string MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public double MyProperty3 { get; set; }
        public bool MyProperty4 { get; set; }

        public RenameThisClass(string line)
        {
            string[] lineSplitted = line.Split(';');    //check the fieldseparator charachter!
            MyProperty1 = lineSplitted[0];
            MyProperty2 = int.Parse(lineSplitted[1]);
            MyProperty3 = double.Parse(lineSplitted[2]);
            MyProperty4 = bool.Parse(lineSplitted[3]);
        }
    }
}
