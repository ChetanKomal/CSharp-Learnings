using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oops;
namespace oops
{   
    public class Oop1:abstraction.abstractcls
    {
        public override void a()
        {
            Console.WriteLine("abstract method from abstractcls");
        }
        public Oop1()
        {
            Console.WriteLine("constructor called");
        }
        public void abc()
        {
            Console.WriteLine("method abc() called");
        }
        public virtual void xyz()
        {
            Console.WriteLine("method xyz() called");
        }
        static void Main(String[] args)
        {
            Console.WriteLine("ck");
            Oop1 obb = new Oop1();
            obb.x();
        }

    }
    
}
namespace xyz
{
    public class oop2 : Oop1
    {
        public static string operator +(oop2 o1, oop2 o2)
        {
            return "objects added success";
        }
        public override void xyz()
        {
            Console.WriteLine("xyz() from oop2");
        }
        public new void abc()
        {
            Console.WriteLine("abc() from oop2");
        }
        static void Main()
        {
           

            oop2 obj2 = new oop2();
            obj2.xyz();
            obj2.abc();

            Oop1 p; //reference variable
            oop2 ob = new oop2();
            p = ob;
            p.abc();
            p.xyz();
           string c = obj2 + ob;
            Console.WriteLine(c);
        }
    }
    public class ck: OOPS.abc
    {
        public void interm()
        {
            Console.Write("method from ck class");
        }
        public void rr()
        {
            Console.WriteLine("rr method from ck class");
        }

    }
}