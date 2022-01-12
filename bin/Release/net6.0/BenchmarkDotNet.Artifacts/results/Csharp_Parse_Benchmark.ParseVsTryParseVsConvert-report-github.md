``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|    Method |     Mean |    Error |   StdDev |
|---------- |---------:|---------:|---------:|
|    BParse | 17.19 ns | 0.130 ns | 0.122 ns |
| BTryParse | 18.11 ns | 0.110 ns | 0.103 ns |
|  BConvert | 17.21 ns | 0.108 ns | 0.101 ns |
