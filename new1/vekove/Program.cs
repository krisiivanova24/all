using System;


namespace vekove
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            long hours = days * 24;
            ulong minutes = (ulong)(hours * 60);
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);

            byte counter = 0;
            for (int i = 0; i < 260; i++)
            {
                counter++;
                Console.WriteLine(i);
            }

            int hex = 0xFE;
            int dec = 254;
            if (hex == dec)
            {
                Console.WriteLine("Bravooo!!!!");
            }
        }
    }
}
