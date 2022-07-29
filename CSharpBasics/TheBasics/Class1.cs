using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;
namespace Class1
{
    public class class12
    { 
        public void meth()
        {
            Console.WriteLine("this is a sample text.");
        }
        static void Main()
        {
            void func(out int x,out int y)
            {
                x = 20;
                y = 25;
            }
            
            int x;
            int y;
            func(out x,out y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            
           
        }
    }
}
