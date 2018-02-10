using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skorost
{
    class Program
    {
        static void Main(string[] args)
        {
            uint metri = uint.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            ushort seconds2 = (ushort)(hours*3600 + minutes*60 +seconds);
            float mVs = (float)metri/seconds2;
            float kmVh = (float)(mVs * 3.6);
            float mVh = (mVs * (3600.0f/1609));
            Console.WriteLine(mVs);
            Console.WriteLine(kmVh);
            Console.WriteLine(mVh);

            char ch = '\u8449';
            Console.WriteLine($"{ ch}");
        }
    }
}
