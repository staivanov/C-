namespace _6.TriangleArea
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Tarena3TypesCalc
    {
        public static void ThreeSideAre()
        {
            /// Formula for  S = sqrt[p(p-a)(p-b)(p-c)]
            /// Formula for p = (a+b+c)/2
            Console.Write("Enter side a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter side b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter side c = ");
            float c = float.Parse(Console.ReadLine());

            float p = (a + b + c) / 2;
            float rigthSideFormula = p * (p - a) * (p - b) * (p - c);
            float area = (float)Math.Sqrt(rigthSideFormula);

            Console.WriteLine(area);
        }

        public static void SideAndHeight()
        {
            /// Formula is S = (a*h)/2
            Console.Write("Enter side: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter heigth: ");
            float h = float.Parse(Console.ReadLine());

            float area = (a * h) / 2;

            Console.WriteLine(area);
        }

        public static void TwoSideAndDegree()
        {
            Console.Write("Enter side one = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter side two = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter degree = ");
            float degree = float.Parse(Console.ReadLine());

            float area = (a * b * (float)Math.Sin(degree)) / 2;
            Console.WriteLine(area);
        }

        public static void TriangleAreaCalculator(int choise)
        {
            switch (choise)
            {
                case 1: ThreeSideAre();
                    break;
                case 2: SideAndHeight();
                    break;
                case 3: TwoSideAndDegree();
                    break;
                default:
                    Console.WriteLine("Incorrect input!");
                    Console.WriteLine("Please, enter valid number between 1 and 3!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            /// Write a program which calculates the area of a triangle with the following given:
            /// three sides;
            /// side and the altitude to it;
            /// two sides and the angle between them in degrees.

            Console.WriteLine("Choose how to calculate triangle area");
            Console.WriteLine("1 for three side");
            Console.WriteLine("2 for Side and the altitude to it");
            Console.WriteLine("3 for Two sides and  the angle between them in degrees");
            int choise = int.Parse(Console.ReadLine());

            TriangleAreaCalculator(choise);
        }
    }
}
