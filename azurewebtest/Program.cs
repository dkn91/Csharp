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
            string user_input = Console.ReadLine();
            Console.WriteLine(user_input +DateTime.UtcNow.DayOfWeek);
            Console.ReadLine();
        }
    }
}
