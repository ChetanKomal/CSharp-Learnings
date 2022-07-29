using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TheBasics
{
    class arrays:object
    {
        public override string ToString()
        {
            return "Chetan Komal";
        }
        static void Main(String[] args)
        {
            arrays a = new arrays();

            string[] arr = new string[4] { "d","b","a","c" };
            int[,] arr2 = new int[3, 3];
            Console.WriteLine(arr.Length);
            Console.WriteLine();
            Array.Sort(arr);
            foreach(int i in arr2)
            {
               Console.WriteLine(i);
            }
           
        }
    }
}
