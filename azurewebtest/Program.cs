using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azurewebtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0] +DateTime.UtcNow.DayOfWeek);
            Console.ReadLine();
        }
    }
}
