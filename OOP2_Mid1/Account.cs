using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP2_Mid1

{
    class Account
    {
        private int accountNumber,sc;
        private string accountName;
        private double balance;
        private Address address;//1-1 Relation
                                //private double amount;


        public Account(string accountName, double balance, int sc, int acn, Address address)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            this.accountNumber = acn;
            this.sc = sc;
        }



        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public void Withdraw(double amount)
        {
            if(sc==1)
            {
                if (this.balance > amount)//savings
                {
                    this.balance = this.balance - amount;
                    Console.WriteLine("Withdaw Successful");
                }
                else//checking
                {
                    Console.WriteLine("Withdaw Not possible");
                }
            }
            else
            {
                if (this.balance >= amount)
                {
                    this.balance = this.balance - amount;
                    Console.WriteLine("Withdaw Successful");
                }
                else
                {
                    Console.WriteLine("Withdaw Not possible");
                }
            }
                
        }


        public void Transfer(Account receiver, double amount)
        {
            receiver.Deposite(amount);
            this.Withdraw(amount);
            Console.WriteLine("Transfer Successfully Completed");

        }

        public void Deposite(double amount)
        {

            this.balance = this.balance + amount;
            Console.WriteLine("Deposited!!");


        }

        public void PrintAccount()
        {

            Console.WriteLine("\nAccount No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.address.PrintAddress();
        }



    }
}