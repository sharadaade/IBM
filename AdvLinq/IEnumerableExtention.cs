using System;
using System.Collections.Generic;
using System.Text;

namespace IBM.AdvLinq
{
    public static class IEnumerableExtention
    {
        public static IEnumerable<T> NewWhere<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (var item in items)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
