using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BracketChecking
{
    class CheckBraket
    {

        //  Write a program that checks whether the parentheses are placed correctly in an arithmetic expression. Example of expression with correctly placed brackets: ((a+b)/5-d). Example of an incorrect expression: )(a+b)).
        static void Main(string[] args)
        {

            string expression = "((a+b)/5-d)";
            string left = "(";
            string right = ")";
            int count = 0;


            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].ToString() == left)
                {
                    count++;
                   
                }
                else if (expression[i].ToString() == right)
                {
                    count--;                  
                }
            }
                      
           Console.WriteLine(count);

           if (count > 0)
           {
               Console.WriteLine("You have one left bracket more");
           }
           else if (count < 0)
           {
               Console.WriteLine("You have one right bracket more");
           }
           else
           {
               Console.WriteLine("Your expression is correct! Be happy");
           }


        }
    }
}
