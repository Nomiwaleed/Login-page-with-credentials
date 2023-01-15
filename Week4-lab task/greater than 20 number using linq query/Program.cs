using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greater_than_20_number_using_linq_query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var array = new String[] { "20", "30", "10", "15", "50", "12", "80", "100", "800", "804" };
            //var val = from number in array select number;

            //foreach (var item in val)
            //{
            //    if(Convert.ToInt32(item) > 20)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.ReadKey();

            var array = new int[] { 20, 30, 10, 15, 50, 12, 80, 100, 800, 804 };
            //var val = array.Where(a => a > 20);
            foreach (var item in array.Where(a => a > 20))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
