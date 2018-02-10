using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravoygylnik
{
    class Program
    {
        static void Main(string[] args)
        {
            float strana1 = float.Parse(Console.ReadLine());
            float strana2 = float.Parse(Console.ReadLine());
            float peri = (2*strana1 + 2*strana2);
            float lice = (strana1 * strana2);
            decimal diagonal = (decimal)(Math.Sqrt(strana1 * strana1 + strana2 * strana2));
            Console.WriteLine(peri);
            Console.WriteLine(lice);
            Console.WriteLine(diagonal);
        }
    }
}
