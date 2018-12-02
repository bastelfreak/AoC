using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch

            List<String> list = Properties.Resources.input_AoC02.Split("\r\n").ToList();
            string result = "";
            foreach (string id in list)
            {
                try
                {
                    // get the first string from `list` that differs only by one character from `id`
                    result = list.Where(predicate: l => l.Zip(id, (a, b) => a != b).Count(t => t) == 1).First();
                }
                catch (InvalidOperationException e)
                {
                   
                }
                if(result.Length > 1)
                {
                    Console.WriteLine(result);
                    Console.WriteLine(id);
                    for (int i = 0; i < result.Length; i++)
                    {
                        char kar = result[i];
                        if ( id.ToCharArray()[i] != result.ToCharArray()[i])
                        {
                            //string cleanedId = result.Replace(kar.ToString(), "");
                            string cleanedID = result.Remove(i, count: 1);
                            Console.WriteLine(result);
                            Console.WriteLine(id);
                            Console.WriteLine(cleanedID);
                            Console.ReadLine();
                            // uqcidadzwtnhsljvxyobmkfy
                            break;
                        }
                    }
                }
            }
        }
    }
}
