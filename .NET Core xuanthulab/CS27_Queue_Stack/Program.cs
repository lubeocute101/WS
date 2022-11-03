using System;
using System.Linq;
using System.Text;

namespace CS27_Queue_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            LinkedList<string> cacbaihoc = new LinkedList<string>();
            var bh1 = cacbaihoc.AddFirst("Bai hoc 1");
            var bh3 = cacbaihoc.AddLast("Bai hoc 3");
            LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1, "Bai hoc 2");
            cacbaihoc.AddLast("Bai hoc 4");
            cacbaihoc.AddLast("Bai hoc 5");
            foreach (var item in cacbaihoc)
            {
                System.Console.WriteLine (item);
            }
        }
    }
}
