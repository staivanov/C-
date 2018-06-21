using System;


namespace _15.AgeAfterTenYears
{
    class AgeAfter
    {
        static void Main(string[] args)
        {


            DateTime birth = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = today.Year - birth.Year;    //people perceive their age in years
            if (
               today.Month < birth.Month
               ||
               ((today.Month == birth.Month) && (today.Day < birth.Day))
               )
            {
                age--;  //birthday in current year not yet reached, we are 1 year younger ;)
                //+ no birthday for 29.2. guys ... sorry, just wrong date for birth
            }


            Console.WriteLine(age);




        }
    }
}
