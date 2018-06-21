using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    class Sunglassess
    {
    //Do you know that the next solar eclipse will occur on April 29, 2014? It will be observable from South Asia, Australia, the Pacific and the Indian Oceans and Antarctica. Spiro is an entrepreneur who wants to cash in on this natural phenomenon. Help him produce protective sunglasses of different sizes. You will get 5% of the profit.
    //Input
    //•	The input data should be read from the console.
    //•	You have an integer number N (always an odd number) specifying the height of sunglasses.
    //The input data will always be valid and in the format described. There is no need to check it explicitly.
    //Output
    //The output should be printed on the console.
    //You should print the sunglasses on the console. The sunglasses consist of three parts: frames, lenses and a bridge (the connection between the two frames). Each frame's width is double the height N and should be printed using the character '*' (asterisk). Print the lenses with the character '/'. Finally, connect the two frames with a bridge that is of size N, using the character '|'. Leave the rest of the space between the frames blank.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char c = '*';
            char k = '/';
            char bridge = '|';
            int f = 2 * n;
            int l = (2 * n) - 2;

            //BORDER
            for (int i = 0; i < f; i++)
            {
                Console.Write(c);
            }

            for (int j = 0; j < n; j++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < f; i++)
            {
                Console.Write(c);
            }


            //CONTENT
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                //Part 1
                Console.Write(c);
                for (int e = 0; e < f - 2; e++)
                {
                    Console.Write(k);
                }
                Console.Write(c);

                //Space and Bridge
                if (i == (n / 3))
                {
                    for (int y = 0; y < n; y++)
                    {
                        Console.Write(bridge);
                    }

                }
                else
                {
                    for (int u = 0; u < n; u++)
                    {
                        Console.Write(" ");
                    }
                }



                //Part 2
                Console.Write(c);
                for (int e = 0; e < f - 2; e++)
                {
                    Console.Write(k);

                }
                Console.Write(c);
                Console.WriteLine();
            }





            //BOREDER
            for (int i = 0; i < f; i++)
            {
                Console.Write(c);
            }

            for (int j = 0; j < n; j++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < f; i++)
            {
                Console.Write(c);
            }
            Console.WriteLine();





        }
    }
}
