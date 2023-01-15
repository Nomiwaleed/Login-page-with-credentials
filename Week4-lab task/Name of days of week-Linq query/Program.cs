using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_of_days_of_week_Linq_query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new String[] {"monday","tuesday", "wednesday", "thursday","friday","Saturday","sunday"};
            var val = from week in array select week;
            
            foreach(var item in val)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
