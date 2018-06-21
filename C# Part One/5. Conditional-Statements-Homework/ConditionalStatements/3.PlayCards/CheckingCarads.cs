using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PlayCards
{
    class CheckingCarads
    {
       // Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

        public static void CardCheck(string c)
        {
            string[] card = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool validCard = false;

            for (int i = 0; i < card.Length; i++)
            {
                if (card[i] == c)
                {
                    validCard = true;
                    Console.WriteLine("Valid card sign? yes");
                }
            }

            if (validCard == false)
            {
                Console.WriteLine("Valid card sign? no");
            }
        }

        static void Main()
        {
            string check = Console.ReadLine();
            
            CardCheck(check);

                            
        }
    }
}
