namespace BankTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BankTask.Accounts;
    using BankTask.Customers;


    class Program
    {
        // A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
        //All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
        //All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
        //Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
        //Deposit accounts have no interest if their balance is positive and less than 1000.
        //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
        //Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.


        static void Main(string[] args)
        {
            //====== Loan Acc - Individual - Interest ======
            Individuals az = new Individuals("Stanislav", "Ivanov");
            Loan nz = new Loan(az, 50000, 5, 12);
            Console.WriteLine("Interest amount is {0}", nz.CalculateInterestAmount());
            Console.WriteLine("Current balance is {0}", nz.Balance);
            //====== Loan Acc - No Interest ======
            //Individuals az = new Individuals("Stanislav", "Ivanov");
            //Loan nz = new Loan(az, 50000, 5, 3);
            //Console.WriteLine(nz.CalculateInterestAmount());

            //====== Loan Acc - Company - Interest ======
            //Companies clubABC = new Companies("Stanislav", "Ivanov", "Club ABC");
            //Loan nz = new Loan(clubABC, 100000, 5, 12);
            //Console.WriteLine(nz.CalculateInterestAmount());
            //====== Loan Acc - Company - No Interest ======
            //Companies clubABC = new Companies("Stanislav", "Ivanov", "Club ABC");
            //Loan nz = new Loan(clubABC, 100000, 5, 2);
            //Console.WriteLine(nz.CalculateInterestAmount());

            //====== Mortgage Acc - Individual - Interrest ======
            //Individuals steve = new Individuals("Steve", "Jobs");
            //Mortgage dz = new Mortgage(steve, 1000000, 5, 12);
            //Console.WriteLine(dz.CalculateInterestAmount());
            //====== Mortgage Acc - Individual - No Interrest ======
            //Individuals steve = new Individuals("Steve", "Jobs");
            //Mortgage dz = new Mortgage(steve, 1000000, 5, 6);
            //Console.WriteLine("Your amount is: {0}", dz.CalculateInterestAmount());
            //dz.DepositMoney(5000);
            //Console.WriteLine("Money in the bank {0}", dz.Balance);

            //====== Mortgage Acc - Company - Interrest ======
            //Companies apple = new Companies("Steve", "Jobs", "Apple");
            //Mortgage dz = new Mortgage(apple, 1000000000, 10, 36);
            //Console.WriteLine("Your interest amount is {0}", dz.CalculateInterestAmount());
            //====== Mortgage Acc - Company - No Interrest ======
            //Companies apple = new Companies("Steve", "Jobs", "Apple");
            //Mortgage dz = new Mortgage(apple, 1000000000, 10, 5);
            //Console.WriteLine("Your interest amount is {0}", dz.CalculateInterestAmount());
            //dz.DepositMoney(300);
            //Console.WriteLine("Apple balance is {0}", dz.Balance);

            //====== Deposit Acc - Individual - Interrest ======
            //Individuals bill = new Individuals("Bill", "Gates");
            //Deposit rich = new Deposit(bill, 1000000000, 11, 24);
            //Console.WriteLine("Mr. Gates amount {0}", rich.CalculateInterestAmount());
            //rich.DepositMoney(1001);
            //Console.WriteLine("Your account balance is {0}", rich.Balance);
            //rich.DrawMoney(1);
            //Console.WriteLine("Money drawed. Your current account balance is {0}", (rich.Balance));
            //====== Deposit Acc - Individual - No Interrest ======
            //Individuals bill = new Individuals("Bill", "Gates");
            //Deposit notSoRich = new Deposit(bill, 950, 11, 4);
            //Console.WriteLine("Amount in account {0}", notSoRich.CalculateInterestAmount());
            //notSoRich.DepositMoney(1001);
            //Console.WriteLine("Your account balance is {0}", notSoRich.Balance);
            //notSoRich.DrawMoney(501);
            //Console.WriteLine("Money drawed. Your current account balance is {0}", (notSoRich.Balance));

            //====== Deposit Acc - Company - Interrest ======
            //Companies microsoft = new Companies("Bill", "Gates", "Microsoft");
            //Deposit rich = new Deposit(microsoft, 5000000, 5, 12);
            //Console.WriteLine("Your amount is {0}", rich.CalculateInterestAmount());
            //rich.DepositMoney(500);
            //Console.WriteLine("Deposit successful. Current balance is {0}", rich.Balance);
            //decimal drawedMoney = rich.DrawMoney(1500);
            //Console.WriteLine("You draw successful {0}. Current balance is {1}", drawedMoney, rich.Balance);
            //====== Deposit Acc - Company - No Interrest ======
            //Companies microsoft = new Companies("Bill", "Gates", "Microsoft");
            //Deposit notSoRich = new Deposit(microsoft, 500, 5, 6);
            //Console.WriteLine("Your amount is {0}", notSoRich.CalculateInterestAmount());
            //notSoRich.DepositMoney(500);
            //Console.WriteLine("Deposit successful. Current balance is {0}", notSoRich.Balance);
            //decimal drawedMoney = notSoRich.DrawMoney(100);
            ////Throw error if drawed money are more from account balance.
            ////decimal drawedMoney = notSoRich.DrawMoney(1500);
            //Console.WriteLine("You draw successful {0}. Current balance is {1}", drawedMoney, notSoRich.Balance);

        }
    }
}
