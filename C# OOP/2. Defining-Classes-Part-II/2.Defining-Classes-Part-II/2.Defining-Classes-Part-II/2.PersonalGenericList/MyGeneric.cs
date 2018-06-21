using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonalGenericList
{
    class MyGeneric
    {
        //Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
        //Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
        //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.


        static void Main(string[] args)
        {

            Generic<int> da = new Generic<int>(3);
            da.Add(5);
            da.Add(9);
            da.Add(15);
            da.Add(20);
            da.AddOnIndex(2, 33);
            Console.WriteLine(da[0]);
            Console.WriteLine(da[1]);
            Console.WriteLine(da[2]);
            Console.WriteLine(da[3]);
          


         

          string dasd = Console.ReadLine();
        }
    }
}
