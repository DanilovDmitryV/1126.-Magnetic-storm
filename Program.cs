using System;
using System.Collections.Generic;

namespace _1126._Magnetic_storm
{
    class Program
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            LinkedList<int> listMax = new LinkedList<int>();
            Queue<int> queue = new Queue<int>();
            while (n != -1)
            {
                queue.Enqueue(n);
                while (listMax.Count != 0 && n > listMax.Last.Value)
                    listMax.RemoveLast();
                listMax.AddLast(n);
                if (queue.Count > m)
                    if (queue.Dequeue() == listMax.First.Value) listMax.RemoveFirst();
                if (queue.Count==m)
                    Console.WriteLine(listMax.First.Value);
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
