using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet10NewThings;

public class Person
{
    public required string Name
    {
        get;
        set => field = value ?? throw new ArgumentNullException(nameof(Name));
    }
    public required int Age
    {
        get;
        set => field = (value >= 18 && value <= 90) ? value : throw new ArgumentOutOfRangeException(nameof(Age), $"Age Must be between 18 and 90 ");
    }
    public string? Address { get; set; }
}
