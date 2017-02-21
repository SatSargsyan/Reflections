using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using GetType to obtain type information: 
            int i = 42;
            bool b = true;

            Type type1 = i.GetType();
            Console.WriteLine(type1);

            Type type2 = b.GetType();
            Console.WriteLine(type2);

            // Using Reflection to get information from an Assembly:
            System.Reflection.Assembly info1 = typeof(System.Int32).Assembly;
            Console.WriteLine(info1);

            System.Reflection.Assembly info2 = typeof(System.Boolean).Assembly;
            Console.WriteLine(info2);

            Console.ReadKey();
        }
    }
}
