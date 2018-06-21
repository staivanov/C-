using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOfExtensionMethods
{
    public static class ExtensionsIEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;

            foreach (var c in arr)
            {
                sum += (dynamic)c;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> arr)
        {
            dynamic product = 0;

            foreach (var c in arr)
            {
                product *= (dynamic)c;
                if (product == 0)
                    break;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> arr)
        {
            dynamic min = long.MaxValue;

            foreach (var c in arr)
            {
                if (c < min)
                    min = c;
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> arr)
        {
            dynamic max = long.MinValue;

            foreach (var c in arr)
            {
                if (c > max)
                    max = c;
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> arr)
        {
            dynamic average = 0, counter = 0;

            foreach (var c in arr)
            {
                average += c;
                counter++;
            }

            if (counter == 0)
            {
                throw new ArgumentException("The passed collection is empty.");
            }

            return average / counter;
        }
    }

}
