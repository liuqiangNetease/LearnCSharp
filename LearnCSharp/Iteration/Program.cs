using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new Colors();
            foreach(string c in colors)
            {
                Console.WriteLine(c);
            }

            var cs = new ColorSet();
            //foreach(var c in cs)
            var it = cs.GetEnumerator();
            while (it.MoveNext())
            {
                var c = it.Current;
                Console.WriteLine(c);
            }
        }
    }
}
