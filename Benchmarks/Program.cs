using System;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkDotNet.Running.BenchmarkRunner.Run<SpanBenchmarks>();
        }
    }
}
