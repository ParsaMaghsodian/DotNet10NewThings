# C# 14 — Features Demonstrated in this Repository

This repository targets C# 14 and .NET 10 and contains small examples that demonstrate several language features introduced (or stabilized) in C# 14. The examples are in `Program.cs`, `Extentions.cs`, `Converter.cs`, and `Money.cs`.

## Features included

- Extension members (extension types)
  - Define methods, properties, operators, and static members that extend a target type using an `extension` declaration.
  - See `Extentions.cs` for examples of `WhereGreaterThan`, `IsEmpty`, `FirstOrFallback`, operator `+`, and static `Create()`.

- List expressions (list literals)
  - Create `List<T>` directly using square-bracket list expressions.
  - Example in `Program.cs`: `List<int> numbers = [1, 2, 3];`.

- Null-conditional assignment and compound assignments
  - Use the null-conditional assignment operator so assignment (including compound assignment) happens only when the left-hand target is non-null.
  - Example in `Program.cs`: `person2?.Address = "Manhattan";` and `person2?.Weight += 81.5;`.

- Lambda parameter modifiers (including `out`, `ref`, and `in`) in lambdas
  - Lambda parameter lists may include parameter modifiers.
  - See `Converter.cs` where an `out` parameter is used with a `TryParse<T>` delegate and `Money.cs` where a `ref` parameter is used in a discount delegate.

- Relational patterns in switch expressions
  - Use relational patterns such as `>=`, `<`, etc., inside `switch` expressions for clear numeric-range matching.
  - Example in `Program.cs` for grade-to-letter mapping.

- `nameof` improvements for generic types
  - `nameof` works with constructed and unbound generic types (for example, `nameof(List<string>)` and `nameof(List<>)`).

- Extension operator and extension static methods
  - Extension declarations allow operator overloads and static members that appear as members of the extended type. See the operator `+` and static `Range` and `Create` methods in `Extentions.cs`.

- Primary constructors for structs
  - Demonstrated in `Money.cs` using the concise primary constructor syntax: `public struct Money(string currency, decimal amount)`.

## Notes and how to enable C# 14
- Ensure your project file targets .NET 10 and sets the language version explicitly if needed (for example add `<LangVersion>14.0</LangVersion>` to your `.csproj`).
- In Visual Studio, you can set the language version via the Project Properties __Advanced__ page or by editing the project file and adding the `__LangVersion__` property.

## Where to look in this repo
- `Program.cs` — top-level usage examples: list expressions, null-conditional assignment, `nameof`, relational `switch`.
- `Extentions.cs` — extension members, extension operators, extension static methods.
- `Converter.cs` — lambdas with parameter modifiers (`out`).
- `Money.cs` — primary constructor for a struct and `ref`-parameter delegate usage.
```
