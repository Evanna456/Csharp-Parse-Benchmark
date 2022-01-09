``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|    Method |     Mean |    Error |   StdDev |
|---------- |---------:|---------:|---------:|
|    BParse | 15.65 ns | 0.055 ns | 0.051 ns |
| BTryParse | 15.45 ns | 0.058 ns | 0.051 ns |
|  BConvert | 17.40 ns | 0.039 ns | 0.035 ns |
