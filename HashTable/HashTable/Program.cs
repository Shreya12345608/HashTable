﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
           // Create a hashtable
        // Using Hashtable class

            HashTableBuilder hashTable = new HashTableBuilder();

            // find frequency of word is 2
            Console.WriteLine($"Frequency of word is {hashTable.FindFrequencyOfWord()}");
            Console.ReadLine();
        }
    }
}
