using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBasics
{
    public class keylogger
    {
        static void Main()
        {
            System.ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                cki = Console.ReadKey();
                Console.WriteLine(cki.Key);
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
