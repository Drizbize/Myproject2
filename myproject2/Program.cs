using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            i = i % 2;
            if (i == 0)
                Console.WriteLine("четное");
            if (i == 1)
                Console.WriteLine("нечётное");
            if (i == -1)
                Console.WriteLine("нечётное");
            Console.ReadKey();      
        }
    }
}
