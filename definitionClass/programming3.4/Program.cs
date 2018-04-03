using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount smetchica = new BankAccount();
            smetchica.Deposit(100);
            smetchica.Withdraw(52);
            Console.WriteLine(smetchica.Balance);

            Person Aleks = new Person();
            Aleks.Name = "Александра Христова";
            Aleks.Age = 17;
            Aleks.IntroduceYourself();

            Person Geri = new Person();
            Geri.Name = "Гергана";
            Geri.Age = 17;
            Geri.IntroduceYourself();

            Person Kris = new Person();
            Kris.Name = "Кристина";
            //Kris.Age = 16;
            Kris.IntroduceYourself();

            Person unknown = new Person();
            Console.WriteLine("Кое е твоето име?");
            unknown.Name = Console.ReadLine();
            Console.WriteLine("Имаш ли 17?");
            Console.WriteLine($"Ти си {unknown.Name}!!");


        }
    }
}
