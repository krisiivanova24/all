using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming3._4
{
    class Person
    {
        //harakteristiki na klasa
        private string name;
        private int age=16 ;
        private List<BankAccount> accs = new List<BankAccount>();

         public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public List<BankAccount> Accs {
            get { return this.accs; }
            set { this.accs = value; }
        }
        //pechat
        public void IntroduceYourself()
        {
            Console.WriteLine($"Аз се казвам {name} и съм на {age}");
        }

        //sumira vs smetki
        public double GetBalance() {
            double sum = accs.Sum(element=> element.Balance);
            return sum;

        }
    }
}
