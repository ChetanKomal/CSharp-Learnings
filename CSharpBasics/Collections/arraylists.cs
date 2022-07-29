using System;
using System.Collections;
//collectuons --> system.collections.generics (linked lists, stacks, queues, and dictionaries)
//            --> system.Collection
//            --> system.collections.concurrent

namespace collectionapp
{
    class arraylist
    {
        static void Main()
        {
           
            //default capacity 8.
            ArrayList arr = new ArrayList();
            arr.Add(123);
            arr.Add(11);
            arr.Add(12);
            arr.Add(156);
            arr.Add(99);
            arr.Sort(); //assending order
            Console.WriteLine($"{arr.Count} {arr.Capacity}");
            foreach (int i in arr)
            {
                Console.WriteLine($"{i}\t");
            }
            //arr.Clear(); // make arylist empty
            Console.WriteLine(arr.Contains(12));
            ArrayList arr2 = new ArrayList();
            arr2 = arr.GetRange(1,3);
            
            foreach (int i in arr2)
            {
                Console.WriteLine($"{i}\t");
            }
            arr.IndexOf(99);
            arr.Insert(1,arr2);
            arr.Remove(99); // remove the specified number from list
            arr.RemoveAt(2);// remove at particular index 
            arr.RemoveRange(0,3); //remove from index 0 to 3 
            arr.Reverse(); 
            arr.TrimToSize(); //Set capacity to actual no of elements in ArrayList.
        }
    }
}