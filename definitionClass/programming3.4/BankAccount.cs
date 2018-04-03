﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming3._4
{
    class BankAccount
    {
        int id;
        double balance;

        public int ID {
            get { return this.id; }
            set { this.id = value; }
        }
        public double Balance {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void Deposit(double amount) {
            this.balance += amount;
        }
        public void Withdraw(double amount) {
            this.balance -= amount;
        }
    }
}
