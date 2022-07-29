using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class hashtables
    {
        static void Main()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            System.Collections.Hashtable ht2 = new System.Collections.Hashtable();
            ht.Add("1", "CK1");
            ht.Add("2", 123);
            ht.Add("3", 23.22);
            ht.Add("4", "CK4");
            ht.Add(false, "CK5");
            ht.Add(6.66, "CK6");
            ht.Add(7, "CK7");
            //ht.Clear(); //remoe all
            bool x = ht.ContainsKey(7);
            Console.WriteLine(x);
            bool y = ht.ContainsValue("CK1");
            Console.WriteLine(y);
            ht.Remove("1");
            Console.WriteLine(ht[false]);
            ArrayList ht.Keys;

        }
    }
}
