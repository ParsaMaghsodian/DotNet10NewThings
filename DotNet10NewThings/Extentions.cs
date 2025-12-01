using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace DotNet10NewThings;

public static class Extentions
{
    extension<T>(IEnumerable<T> source) where T : INumber<T>
    {
        public IEnumerable<T> WhereGreaterThan(T threshold) =>  // instance member
            source.Where(x => x > threshold);
        // instance member for prop
        public bool IsEmpty =>
            !source.Any();

    }
    extension<T>(List<T>) where T : INumber<T>
    {
        public static List<T> Create() // static member
        {
            return new List<T>();
        }

    }

    //public static IEnumerable<T> WhereGreaterThan<T>(this IEnumerable<T> source, T threshold) where T : INumber<T>
    //{
    //    return source.Where(x => x > threshold);
    //}


}
