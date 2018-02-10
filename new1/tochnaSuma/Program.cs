using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochnaSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            decimal num2 = 0;
            for (int i = 0; i < n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());                
                num2 = num2 + num;
               
            }
            Console.WriteLine(num2);


            //double num = 10000000000000000000000000000000000.0;
            //Console.WriteLine(num);
        }
    }
}
