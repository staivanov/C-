using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompanyInfo
{
    class CompanyInformation
    {
        //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.

        public static void PrintCompanyInfo(string company)
        {
            string SoftUni = "Software University";
            string adress = "V.Kanchev, Sofia";
            string phoneNum = "+ 359 899 55 55 92";
            string faxNum = "899 55 55 91";
            string webSite = "http://softuni.bg";
            string firstName = "Svetlin";
            string lastName = "Nakov";
            string age = "25";
            string managerPhone = "359 2 981 981";
            Console.WriteLine();

            if (company == SoftUni)
            {
                Console.WriteLine(SoftUni);
                Console.WriteLine("Adress: " + adress);
                Console.WriteLine("Tel: " + phoneNum);
                Console.WriteLine("Fax number: " + faxNum);
                Console.WriteLine("web site: " + webSite);
                Console.Write("Manager name: " + firstName);
                Console.Write(" " + lastName);
                Console.WriteLine(" " + "(" + "age: " + age);
                Console.Write("tel." + managerPhone + ")");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("hey, try valid name");
            }

        }

        static void Main()
        {
            Console.WriteLine("Enter company name for complete information");
            Console.Write("Name? ");
            string company = Console.ReadLine();

            PrintCompanyInfo(company);

        }
    }
}
