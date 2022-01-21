using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Mid1
{
    class Program
    {
       
        static int AccountNumberGen(int inc)
        {
            int start = 9999;
            int an = start + inc;
            return an;
        }
        static void Main(string[] args)
        {
            bool flag = true;
            int num;

            Console.Write("Numbers of created accounts: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===============================");
            Bank ourBank = new Bank("Developer's bank", num);

            while (flag)
            {
                Console.WriteLine("Open a Bank account (open)\nPerform transactions for an account (account)\nExit the application(quit)\n===========================================") ;
                string option = Console.ReadLine();
                switch (option)
                {
                    case "open":
                        Console.WriteLine("Open Savings Account (savings)\nOpen Checking Account (checking)\nExit from the application (quit)\n=======================================================");
                        string opt = Console.ReadLine();
                        if (opt== "savings")
                        {
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine("Details for your Checking Account:\n==================================\nAccount " + (i + 1));
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Amount: ");
                                double ammount = Convert.ToInt32(Console.ReadLine());                   
                                Console.Write("Date of Birth: ");
                                string dob = Console.ReadLine();
                                Console.Write("Address: ");
                                string address = Console.ReadLine();
                                int sc = 1;

                                ourBank.AddAccount(new Account(name, ammount, sc, AccountNumberGen(i), new Address(dob, address)));
                            }

                        }
                        else if (opt == "checking")
                        {
                            for (int i = 0; i < num; i++)
                            {
                                Console.WriteLine("Details for your Checking Account:\n==================================\nAccount " + (i + 1));
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Amount: ");
                                double ammount = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Date of Birth: ");
                                string dob = Console.ReadLine();
                                Console.Write("Address: ");
                                string address = Console.ReadLine();
                                int sc = 2;

                                ourBank.AddAccount(new Account(name, ammount, sc, AccountNumberGen(i), new Address(dob, address)));
                            }

                        }
                        else if (opt=="quit")
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("WRONG INPUT!!");
                        }
                        break;



                    case "account":
                        {
                            Console.WriteLine("=======================================================\nDeposit money in his account (deposit)\nWithdraw money from his account (withdraw)\nTransfer money to another account (transfer)\nDisplay the number of transactions and balance (show)\nExit from the application (quit)\n=======================================================");
                            opt = Console.ReadLine();
                            if(opt== "deposit")
                            {
                                Console.WriteLine("Enter amount:");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                ourBank.Transaction(1, amount);
                                break;
                            }
                            else if (opt == "withdraw")
                            {
                                Console.WriteLine("Enter amount:");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                ourBank.Transaction(2, amount);
                                break;
                            }
                            else if (opt == "transfer")
                            {
                                Console.WriteLine("Enter amount:");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Enter reciever's account:");
                              //Account reciever=Console.ReadLine() ;
                                ourBank.Transaction(3, amount);
                              //ourBank.Transaction(3, amount, reciever);
                                break;
                            }
                            else if (opt == "show")
                            {
                                Console.WriteLine("\n=======================================================");
                                ourBank.PrintAllAccounts();
                                break;
                            }
                            else if (opt == "quit")
                            {
                                flag = false;
                            }
                            else
                            {
                                Console.WriteLine("WRONG INPUT!!");
                            }
                            break;
                        }
                    case "quit":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Input!!");
                        continue;

                }
            }
        }
    }
}

