using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBasics
{
    class strings
    {
        static void Main(String[] args)
        {
            string d = "chetan komal";
            String c = new String("chetan komal");
            Console.WriteLine(c[0]);
            Console.WriteLine(c.Length);
            Console.WriteLine(c.IndexOf("a"));
            Console.WriteLine(c.Substring(3));
            Console.WriteLine(Object.Equals(c, d));
            
        }
    }
}
