using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace PersonalGenericList
{
    class MyGeneric
    {
        //Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
        //Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
        //Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.


        static void Main(string[] args)
        {
            GenericList<int> myGenericList = new GenericList<int>(10) { };
            myGenericList.Add(15);
            myGenericList.Add(33);
            myGenericList.Add(312);
            myGenericList.Insert(1, 55);
            Console.WriteLine(myGenericList[1]);
     
        }
    }
}
