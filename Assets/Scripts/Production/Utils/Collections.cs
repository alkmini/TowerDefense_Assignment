using System.Collections.Generic;

namespace Tools
{
    public static class Collections
    {
        //Avoid allocation => non garbage generation
        public static void Reboot<T>(Queue<T> queue, T element)
        {
            queue.Clear();
            queue.Enqueue(element);
        }

        //Avoid allocation => non garbage generation
        public static void Reboot<T>(ICollection<T> collection, T element)
        {
            collection.Clear();
            collection.Add(element);
        }

        //Avoid allocation => non garbage generation
        public static void Reboot<T>(ICollection<T> collection, IEnumerable<T> items)
        {
            collection.Clear();
            foreach (T item in items)
            {
                collection.Add(item);
            }
        }

        //Avoid allocation => non garbage generation
        public static void Reboot<T, K>(IDictionary<T, K> dictionary, T key, K value)
        {
            dictionary.Clear();
            dictionary.Add(key, value);
        }
    }
}