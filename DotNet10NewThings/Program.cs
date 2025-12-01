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
    _ => "F"  // else or default
};
Console.WriteLine($"letterGarde:{letterGarde}");
List<int> numbers1 = [1, 2, 3, 4, 5];


List<int> numbers2 = [6, 7, 8, 9, 10];

// Concatenate two enumerables into a single one using the operator extension
var combinedList = numbers1 + numbers2;
Console.WriteLine($"numbers1 + numbers2 is");
foreach (var number in combinedList)
{
    Console.WriteLine(number);
}
List<int> numbres3 = [];
Console.WriteLine(numbres3.FirstOrFallback(0));

var cheque = new Money("USD", 200);
var savings = new Money("USD", 100);
var total = cheque + savings;
total += new Money("USD", 10);
Console.WriteLine(total);
int value = Converter.StringToInt("12345");
Console.WriteLine(value);
var discounted = new Money("USD", 500).Apply10PercentDiscount();
Console.WriteLine(discounted);

// Using string as an arbitrary type parameter
Console.WriteLine(nameof(List<string>));
// Output: List

// No type parameter (unbounded generic)
Console.WriteLine(nameof(List<>));
// Output: List

Console.ReadLine();
