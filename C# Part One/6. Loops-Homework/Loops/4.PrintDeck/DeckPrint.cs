using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PrintDeck
{
    class DeckPrint
    {
        //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

        static void Main(string[] args)
        {
            //Console.WriteLine("♣");
            //Console.WriteLine("♦");
            //Console.WriteLine("♥");
            //Console.WriteLine("♠");

            //11 = J
            //12 = Q
            //13 = K
            //14 = A
            char[] symbol = new char[] { '♣', '♦', '♥', '♠' };

            for (int i = 2; i < 15; i++)
            {

                for (int j = 0; j < symbol.Length; j++)
                {
                    if (i <= 10) { 
                    Console.Write(i + symbol[j].ToString() + " ");
                    }
                }

                switch (i)
                {
                    case 11:
                        for (int j = 0; j < symbol.Length; j++)
                        {
                            Console.Write("J" + symbol[j].ToString() + " ");
                        } break;
                    case 12:
                        for (int j = 0; j < symbol.Length; j++)
                        {
                            Console.Write("Q" + symbol[j].ToString() + " ");
                        } break;
                    case 13:
                        for (int j = 0; j < symbol.Length; j++)
                        {
                            Console.Write("K" + symbol[j].ToString() + " ");
                        } break;
                    case 14:
                        for (int j = 0; j < symbol.Length; j++)
                        {
                            Console.Write("A" + symbol[j].ToString() + " ");
                        } break;
                }
                Console.WriteLine();
            }

        }
    }
}
