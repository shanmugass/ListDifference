using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public static class ListExtension
    {
        public static List<string> Difference(this List<string> list1, List<string> list2)
        {

            var allListContent = list1.Union(list2);

            var difference1 = allListContent.Except(list2);

            var difference2 = allListContent.Except(list1);

            return difference1.Union(difference2).ToList();
        }
    }
}
