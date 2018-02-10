using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promeni16
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num = Console.ReadLine();
            //int dec = Convert.ToInt32(num, 2);
            //Console.WriteLine(dec);

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", num1);
            Console.WriteLine("b = {0}", num2);
            int x = num1;
            num1 = num2;
            num2 = x;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");
        }
    }
}
