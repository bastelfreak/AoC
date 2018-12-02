using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<List<int>> list = new List<List<int>>();
            // https://stackoverflow.com/questions/22090007/print-distinct-characters-in-a-string-with-count
            // https://www.dotnetperls.com/nested-list
            // https://stackoverflow.com/questions/6370028/return-list-using-select-new-in-linq
            //List<List<String>> list = Properties.Resources.input_AoC02.Split("\n").Select(s => s.Select((character, index) => new List<String>{character.ToString(), character.Count()})).ToList();
            List<String> list = Properties.Resources.input_AoC02.Split("\r\n").ToList();
            int[] occurrences = { 2, 3 };
            List<List<int>> thewholylist = new List<List<int>>();
            foreach (string id in list)
            {
                thewholylist.Add(id.GroupBy(c => c). // group all chars in the string
                Where(g => occurrences.Contains(g.Count())). // filter for chars that occour 2 or 3 times
                Select(grp => grp.Count()).ToList());
            }
            int two = 0;
            int three = 0;
            foreach (List<int> listwiththings in thewholylist)
            {
                if (listwiththings.Contains(2))
                {
                    two += 1;
                }
                if (listwiththings.Contains(3))
                {
                    three += 1;
                }
            }
            Console.WriteLine(two * three);
            // 9139
            Console.ReadLine();
        }
    }
}
