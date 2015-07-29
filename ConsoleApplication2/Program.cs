using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            var list1 = new List<string> { "A", "B", "C", "D", "X" };

            var list2 = new List<string> { "A", "B" };

            var firstTest = list1.Difference(list2);

            PrintResults(firstTest);

            var list3 = new List<string> {"X", "Y", "Z", "A"};

            var secondResult = list3.Difference(list1);

            PrintResults(secondResult);

            Console.ReadKey();
        }

        static void PrintResults(List<string> results)
        {
            Console.WriteLine("Result:");
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

        }
    }
}
