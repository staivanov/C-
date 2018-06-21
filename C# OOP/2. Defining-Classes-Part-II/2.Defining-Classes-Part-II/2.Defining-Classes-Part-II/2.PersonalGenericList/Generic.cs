using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalGenericList
{
    public class Generic<T>
    {
        private const int defaultCapacity = 16;

        private T[] arr;
        private int size;
        private int count;

        //Constructors
        public Generic()
        {
            arr = new T[defaultCapacity];
        }

        public Generic(int size)
        {
            if (size <= 2)
            {
                throw new ArgumentException("Generic list size cant be below 2.");
            }
            this.size = size;
            this.arr = new T[size];


        }
        //Props
        public int Capacity
        {
            get { return this.arr.Length; }
        }

        public int Count
        {
            get { return this.count; }
        }



        public T this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index cant be bellow zero!");
                }
                arr[index] = value;
            }
        }

        //Methods
        public void Add(T element)
        {
            if (count >= Capacity)
            {
                ResizeArray();
            }
            arr[count] = element;
            count++;
        }

        private void ResizeArray()
        {
            T[] newArray = new T[this.arr.Length * 2];
            Array.Copy(arr, 0, newArray, 0, arr.Length);
            arr = newArray;
        }
        //TODO
        public void RemoveAtIndex()
        {

        }
        //TODO
        public void AddOnIndex(int index, T element)
        {
            if (Count == arr.Length)
            {
                ResizeArray();
            }

            Array.Copy(arr, 0, arr, index, arr.Length - 1 - index);
            arr[count] = element;
            count++;
        }

        public int Contain(T element)
        {
           int  indexer = Array.IndexOf(arr, element);
           return indexer;

        }

        public bool IsContain(T element)
        {
            bool truth = true;          
            int indexer = Array.IndexOf(arr, element);

            if (indexer == -1) 
            {
                return false;
            }          
             return truth;
        }

        public void Clear()
        {
            this.arr = new T[defaultCapacity];
        }

    }
}
