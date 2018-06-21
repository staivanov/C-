using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MoonGravity
{
    class GravityMoon
    {
        //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth

        static void Main()
        {
            Console.WriteLine("The gravitational field of the Moon is approximately 17% of that on the Earth.Enter your weight and this program will calculate how heavy will be on Moon.");
            Console.Write("Enter weight in kg: ");
            float weight = float.Parse(Console.ReadLine());

            float moonWeight = weight * 0.17f;
            Console.WriteLine("Moon weight: {0}kg", moonWeight);

        }
    }
}
