``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |     Mean |   Error |  StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------------------- |-------------- |-------------- |------- |---------:|--------:|--------:|------------:|------:|------:|------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      9 | 333.6 ms | 1.73 ms | 1.62 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      9 | 868.8 ms | 4.58 ms | 4.06 ms | 272000.0000 |     - |     - | 356613504 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      9 | 533.8 ms | 1.95 ms | 1.83 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      9 | 526.0 ms | 1.81 ms | 1.60 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      9 | 328.1 ms | 4.48 ms | 4.19 ms |           - |     - |     - |        48 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      9 | 963.5 ms | 5.89 ms | 5.51 ms |  42000.0000 |     - |     - | 355556856 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      9 | 583.9 ms | 1.67 ms | 1.56 ms |           - |     - |     - |        48 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      9 | 426.7 ms | 3.24 ms | 3.03 ms |           - |     - |     - |           - |
