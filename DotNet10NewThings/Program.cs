// See https://aka.ms/new-console-template for more information

using DotNet10NewThings;

// Extention members

var numbers = new List<int>() { 1, 2, 3, 4, 5 };
var results = numbers.WhereGreaterThan(4);
foreach (var item in results)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Is Empty : {numbers.IsEmpty}");

// field keyword
//var person1 = new Person() { Name =null , Age = 0};
// Null-Conditional Assignment
Person person2 = new() { Name = "John Doe", Age = 33 };
person2?.Address = "Manhattan"; // Only if person2 isn't null
person2?.Name = "Parsa"; // Only if person2 isn't null
person2?.Age = 21; // Only if person2 isn't null
// Compound Assignments Supported
person2?.Weight += 81.5; // Only if person2 isn't null
Console.WriteLine($"Name:{person2?.Name}, Age:{person2?.Age}, Address:{person2?.Address}, Weight:{person2?.Weight}");

int numberGrade = 85;
string? letterGarde;
letterGarde = numberGrade switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};
Console.WriteLine($"letterGarde:{letterGarde}");

Console.ReadLine();

