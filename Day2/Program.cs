using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var checkTwo = 0;
            var checkThree = 0;
            foreach (var line in File.ReadAllLines("input.txt"))
            {
                var counts = line.GroupBy(x => x).Select(x => x.Count());
                if (counts.Contains(2))
                {
                    checkTwo++;
                }
                if (counts.Contains(3))
                {
                    checkThree++;
                }
            }

            Console.WriteLine($"{checkTwo} * {checkThree} = {checkTwo * checkThree}");
        }
    }
}
