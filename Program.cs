using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Csharp_Parse_Benchmark.Helpers.StringRandom;

namespace Csharp_Parse_Benchmark
{
    public class ParseVsTryParseVsConvert
    {
        private StringRandom myString = new StringRandom();
        private readonly string data;

        public ParseVsTryParseVsConvert()
        {
            data = myString.generateNumber(10);
        }

        [Benchmark]
        public long BParse()
        {
            long number;
            number = long.Parse(data);
            return number;
        }

        [Benchmark]
        public long BTryParse()
        {
            long number;
            long.TryParse(data, out number);
            return number;
        }

        [Benchmark]
        public long BConvert()
        {
            long number;
            number = Convert.ToInt64(data);
            return number;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ParseVsTryParseVsConvert>();
            Console.ReadLine();
        }
    }
}