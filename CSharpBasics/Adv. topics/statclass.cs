using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBasics;
using Class1;
namespace Advtopics
{
    public static class statclass
    {
        public static void t3(this Extmethods p)
        {
            Console.WriteLine("t3() method");
        }
        public static void t4(this Class1.class12 p2)
        {
            Console.WriteLine("t4() from static class called.");
        }
    }
}
