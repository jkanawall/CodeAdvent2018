using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    class Program
    {
        private static HashSet<int> reachedFrequencies = new HashSet<int> { 0 };
        static void Main(string[] args)
        {
            var result = ParseFrequencies(0);
            Console.WriteLine($"Frequency: {result.freq}");
            Console.WriteLine($"First Repeat: {result.rep}");
        }

        static (int freq, int? rep) ParseFrequencies(int frequency)
        {
            int? repeat = null;
            foreach (var num in File.ReadAllLines("input.txt"))
            {
                frequency += Convert.ToInt32(num);
                if (repeat is null && !reachedFrequencies.Add(frequency))
                {
                    repeat = frequency;
                }
            }

            if (repeat is null)
            {
                (_, repeat) = ParseFrequencies(frequency);
            }
            return (frequency, repeat);
        }
    }
}
