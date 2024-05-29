using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item) where T : IComparable
        {
            foreach (T obj in items)
            {
                if (item.CompareTo(obj) >= 0)
                {
                    yield return obj;
                }
            }
        }
    }
}