using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace DotNet10NewThings;

public static class Extentions
{
    extension<T>(IEnumerable<T> source) where T : INumber<T>
    {
        // Extension method
        public IEnumerable<T> WhereGreaterThan(T threshold) =>  
            source.Where(x => x > threshold);

        // Extension property
        public bool IsEmpty =>
            !source.Any();

        // Extension method
        public T FirstOrFallback(T fallback)
            => source.FirstOrDefault() ?? fallback;

        // Extension operator method
        public static IEnumerable<T> operator +(IEnumerable<T> first, IEnumerable<T> second)
        {
            foreach (var item in first)
                yield return item;
            foreach (var item in second)
                yield return item;
        }

        // Extension static method
        public static List<T> Create()
        {
            return new List<T>();
        }

    }

    extension<T>(IEnumerable<T> enumerable)
    {
        // Extension static method
        public static IEnumerable<T> Range(int start, int count, Func<int, T> generator)
            => Enumerable.Range(start, count).Select((_, i) => generator(i));
    }


    //public static IEnumerable<T> WhereGreaterThan<T>(this IEnumerable<T> source, T threshold) where T : INumber<T>
    //{
    //    return source.Where(x => x > threshold);
    //}


}
