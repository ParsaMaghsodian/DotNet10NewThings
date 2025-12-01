using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet10NewThings;

public class Converter
{
    // Simple lambda parameters with modifiers
    delegate bool TryParse<T>(string text, out T result);
    public static int StringToInt(string text)
    {
        TryParse<int> parse1 = (text, out result) => Int32.TryParse(text, out result);
        // TryParse<int> parse2 = (string text, out int result) => Int32.TryParse(text, out result); => before C# 14.0
        bool result = parse1.Invoke(text, out int value);
        return result ? value : 0;
    }


}
