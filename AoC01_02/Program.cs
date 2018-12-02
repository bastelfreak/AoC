using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> results = new List<int>();
            List<int> corrections = new List<int>();
            Boolean exit = false;
            results.Add(0);
            try
            {
                using (StreamReader sr = new StreamReader("../../../../input.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();
                        //Console.WriteLine("We got the following correction:" + line);
                        corrections.Add(int.Parse(line));
                    }
                    Console.WriteLine("We read " + corrections.Count + " values from the textfile");
                    while (! exit )
                    {
                        foreach (int correction in corrections)
                        {

                            int oldResult = results.Last();
                            int newResult = oldResult + correction;
                            if (results.Contains(newResult) && (exit == false))
                            {
                                Console.WriteLine("Our recurring frequency is " + newResult);
                                exit = true;
                            }
                            results.Add(newResult);
                        }
                    }
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine("We were unable to find the correct fils");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            // hack to keep the console open
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
