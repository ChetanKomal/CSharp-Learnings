using System;
using System.Text;
namespace Program
{
    enum food:int{
        chai=1,
        coffee,
        lasi,
        sutta
    }
    class c1:Object
    {
        private int _a;
        private string _str;
        private int _ck;
        private food _food;
        public c1()
        {
            this._a = 10;
            this._str = "CK";
            this._food = food.coffee;
        }
        public c1(int a, string b)
        {
            this._a = a;
            this._str = b;
        }
        public int a
        {
            get { return this._a; }
            set { this._a = value; }
        }
        public string str
        {
            get { return this._str; }
            set { this._str = value; }
        }
        public int ck // this property will work as constant for all the instances of the class itis read 
        {              // every instance will have property ck with value 786 in it.
            get;
        } = 786;
        
        static int Main(String[] args)
        {

            c1 obj = new c1();
            //obj.ck = 1000; // acces the property ck line 32 -37
            obj._ck = 12; // access the property on line
            obj._a = 1901;
            Console.WriteLine(obj._a);
            Console.WriteLine(obj.a);
            // both refer to same property with diff name.

            Console.WriteLine(obj._ck);

            Console.WriteLine(obj.ck);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("CK");
            Console.WriteLine("\n\n");
            Console.WriteLine(obj.ck);
            c1 obj2 = new c1();
            Console.WriteLine(obj2.ck);
            obj2._food = food.chai;

            return 0;
        }
    }
}