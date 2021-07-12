﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoerseDataConvert
{
    public  class WarningStat
    {
        private Dictionary<int, int> tableWarnings;
        private  string curFile;
        public WarningStat(string fileName)
        {
            curFile = fileName;
            tableWarnings = new Dictionary<int, int>();
        }
        public  void Add(int tag)
        {
            if (tableWarnings.ContainsKey(tag))
            {
                tableWarnings[tag]++;
            }
            else
            {
                tableWarnings.Add(tag, 1);
            }
        }
        public  void PrintWarnigs()
        {
            if (tableWarnings.Count == 0)
            {
                Console.WriteLine($"There is no warnings in file {curFile}");
            }
            else
            {
                Console.WriteLine($"Warnings in file {curFile}");
                foreach (var warning in tableWarnings)
                {
                    int tag = warning.Key;
                    int count = warning.Value;
                    Console.WriteLine($"Invalid tag \"{tag}\": {count} times.");
                }
            }
        }
    }
}
