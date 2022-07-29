using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advtopics
{
    public class Extmethods
    {
       public void t1()
        {
            Console.WriteLine("t1() method");
        }
        public void t2()
        {
            Console.WriteLine("t2 called");
        }
        static void Main()
        {
            Extmethods e1 = new Extmethods();
            e1.t3();
        }
    }
}
