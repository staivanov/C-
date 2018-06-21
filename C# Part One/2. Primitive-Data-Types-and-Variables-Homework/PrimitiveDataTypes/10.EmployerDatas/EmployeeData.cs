using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployerDatas
{
    class EmployeeData
    {
//        A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


        static void Main(string[] args)
        {
            string firstName = "Stanislav";
            string lastName = "Ivanov";
            byte age = 24;
            string gender = "male";
            long personID = 4336152582L;
            int uniqueNum = 27569999;

            Console.WriteLine("My name is: {0} {1}", firstName, lastName);
            Console.WriteLine("I am {0} old", age);
            Console.WriteLine("My gender is {0}", gender);
            Console.WriteLine("Personal ID: {0}", personID);
            Console.WriteLine("Unique Number: {0}", uniqueNum);
        }
    }
}
