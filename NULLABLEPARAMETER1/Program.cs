using System;

namespace NULLABLEPARAMETER1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Nullable<int> n = null;
            Console.WriteLine(n.GetValueOrDefault());
            int? n1 = null;
           Console.WriteLine(n1.GetValueOrDefault());
            int? n2 = 47;
            Console.WriteLine(n2.GetValueOrDefault());
            Nullable<int> n3 = 457;
            Console.WriteLine(n3.GetValueOrDefault());
            int? a = null;
            int? b = 2345;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Nullable<int> d = null;
            Console.WriteLine(d.HasValue);
            Nullable<int> e = 7;
            Console.WriteLine(e.HasValue);
            int? f = null;
            int g = f ?? 3;
            Console.WriteLine(f);

        }

    }
}
   