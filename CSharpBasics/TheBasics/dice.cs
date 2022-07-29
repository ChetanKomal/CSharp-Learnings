using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheBasics
{
    public class dice
    {

         static void Main()
        {
             static int roll_dice(Random obj)
            {
                return obj.Next(6);
            }
            string ?c ;
            Random obj = new Random();
            do
            {
                Console.WriteLine(roll_dice(obj));
                Console.WriteLine("do again? : ");
                c = Console.ReadLine();

            } while (c!= "n");
        }
    }
}
