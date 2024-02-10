using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    internal class Program
    {
        static void PrintArr(int[] arr) {
            foreach (var i in arr) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] nums = { 45, 65, 76, 89, 78, 98, 87, 86, 92 };

            //SQl query general Syntax: select data from table_name where condition
            //LINQ general syntax: from varible in collection where condition select variable
            var filtered2 = (from i in nums where i >= 80 select i).ToArray();

            PrintArr(nums);
            PrintArr(filtered2);
            //int[] filtered = new int[nums.Length];
            //int count = 0;
            //foreach (var i in nums)
            //{
            //    if(i >= 80)
            //    {
            //        filtered[count++] = i;  
            //    }
            //}
            //PrintArr(filtered);
        }
    }
}
