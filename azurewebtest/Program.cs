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

            Console.WriteLine("how tall are you?");
            int ht = int.Parse(Console.ReadLine());
            if(ht > 5)
            {
                Console.WriteLine("You are tall");
            }
            else
            {
                Console.WriteLine("oh hum!!!");
            }
            Console.ReadLine();
        }
    }
}
