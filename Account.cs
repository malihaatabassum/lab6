using System;
using System.Collections.Generic;
using System.Text;

namespace std
{
    class Account

    {
        string accName;
        string acId;
        int balance;

        public String Name
        {
            set { accName = value; }
            get { return accName; }
        }
        public string Id
        {
            set { acId = value; }
            get { return acId; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Holder Name : " + Name);

            Console.WriteLine("Account ID : " + Id);

            Console.WriteLine("Account initial balance : " + Balance);

        }

        public void Deposit(int amount)
        {

            balance = balance + amount;
            Console.WriteLine("Total amount " + balance + " TK");
        }




        public void Withdraw(int amount)
        {

            balance = balance - amount;
            receiver.balance += amount;

            Console.WriteLine("Now your total amount " + balance + " TK");


        }



        public void Transfer(int amount, Account receiver)
        {
            if (amount >= 0 && balance >= amount)
            {
                balance = balance - amount;
                receiver.balance += amount;
            }
        }

    }
}