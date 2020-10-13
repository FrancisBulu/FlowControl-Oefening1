using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl_Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            Console.WriteLine("De getallen zijn: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {i} ");
                som = som + i;
            }
            Console.WriteLine($" en de som is {som}");
            Console.ReadKey();
        }

    }
}
