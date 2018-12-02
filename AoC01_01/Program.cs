using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<int> list = Properties.Resources.input_AoC01.Split("\n").Select(s => Convert.ToInt32(s)).ToList();
            list.ForEach(entry => counter += entry);
            Console.WriteLine("Our counter is at:" + counter);
            Console.ReadLine();
        }
    }
}
