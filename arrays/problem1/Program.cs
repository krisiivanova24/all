using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] uspeh = new float[8];
            string[] firstName = new string[] {"Aleksandra", "gergana", "Desislava", "Ivaylo", "Kristina", "Mariela", "Mario", "Cvetina"};
            Console.WriteLine(firstName.Length);
            firstName[0] = "Alexandra";
            firstName[1] = "Gergana";
            float sum = 0f;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Оценка за " + firstName[i] + " e: ");
                uspeh[i] = float.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{uspeh[i]} - ");
                sum = sum + uspeh[i];
            }
            Console.WriteLine("\nÄvarage = " + sum / uspeh.Length);
        }
    }
}
