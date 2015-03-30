using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public static class IEnumerableExtensions
    {
        public static T SumIEnumerable<T>(this IEnumerable<T> collection)
        {
            T sum = (dynamic)0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T ProductIEnumerable<T>(this IEnumerable<T> collection)
        {
            T product = (dynamic)1;
            foreach (var item in collection)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T MinIEnumerable<T>(this IEnumerable<T> collection)
        {
            return collection.Min();
        }

        public static T MaxIEnumerable<T>(this IEnumerable<T> collection)
        {
            return collection.Max();
        }

        public static double AverageIEnumerable<T>(this IEnumerable<T> collection)
        {
            double sum = 0.0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum / collection.Count();
        }
    }
}
