using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv._topics
{

    class _delegates
    {
        //2 delegates defined
        public delegate void abcdel();
        public delegate void xyzdel();
        //3rd delegate defined 
        public delegate void pqr();
        //anonymous method delegates
        public delegate void anon();
        public static bool func2(int a)
        {
            return true;
        }
        public static string func1(int a,double b)
        {
            
            return "ckck";
        }
        public static void abc(int a)
        {
            Console.WriteLine("abc() called from acton delegate.");
        }
        public void abc()
        {
            Console.WriteLine("abc() called");
        }
        public void xyz()
        {
            Console.WriteLine("xyz() called");
        }
        static void Main()
        {
            _delegates obj = new _delegates();
            //delegate bind to abc method
            abcdel ad = new abcdel(obj.abc); // or abcdel ad = obj.abc;
            ad.Invoke(); // or can call using ad();
            //delegate bind to xyz method.
            xyzdel xy = new xyzdel(obj.xyz);  // or xyzdel xy = obj.xyz;
            xy.Invoke(); //or can call using xy();
            pqr p1 = obj.xyz;
            // binding delegate to 2 methods and calling them
            p1 += obj.abc;
            Console.WriteLine("\n\n\n");
            // both methods are called first abc then xyz.
            p1.Invoke(); // or p1();
                         //we can also bind these 2 methods with the ist or second delegate as both are same in signature.

            //anonymous method
            anon _c = delegate ()
            {
                Console.WriteLine("chetan");
            };
            _c();
            _c += obj.abc;
            //lambda expressions 
            anon _d = () => { Console.WriteLine("ck inside lambda exp."); };
            // anon _d = (para1,para2, para3) => { Console.WriteLine("chetan inside lambda exp."); };
            //noneed to specify parameter type as delegate already knows it in the definit  ion.
            _d();

            Console.WriteLine("\n\n\ngeneric delegates:");
            //predefined delegates
            //func delegate
            Func<int, double, string> xbj = new Func<int, double, string>(func1);
            string x = xbj(5,4.44);
            Console.WriteLine(x);
            //action delegate
            Action<int> xbj2 = new Action<int>(abc);
            xbj2(3);
            //predicate delegate
            Predicate<int> xbj3 = new Predicate<int>(func2);
            Console.WriteLine(xbj3(12));
        }
    }
}
