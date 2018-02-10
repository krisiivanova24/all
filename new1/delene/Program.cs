using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delene
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n ; i++)
            {
                int delimo = int.Parse(Console.ReadLine());
                int delitel = int.Parse(Console.ReadLine());
                sum = sum + delimo % delitel;
            }
            Console.WriteLine(sum);
        }
    }
}
