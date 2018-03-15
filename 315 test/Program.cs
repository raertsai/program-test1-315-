using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _315_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.White;
            // 設定變數
            double rate = 0.3;

            // desplay
            Console.WriteLine("recent rate{0}", +rate);

            //count
            Console.WriteLine("1000convert into:"+(1000 * rate) + "NT dollars");

            // enter# then count resualt
            Console.Write("enter #:");
            string input = Console.ReadLine();

            // desplay resualt
            double total = int.Parse(input) * rate;
            Console.WriteLine ("get:" + total);


            // end
            Console.ReadLine();
            
        }
    }
}
