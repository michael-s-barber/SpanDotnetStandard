using BenchmarkDotNet.Attributes;
using SpanDotnetStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Benchmarks
{
    [CoreJob][ClrJob]
    public class SpanBenchmarks
    {
        NativeTests _nativeTests = new NativeTests();
        StandardTests _standardTests = new StandardTests();

        double[] _values = Enumerable.Range(0, 32).Select(a => (double)a).ToArray();

        [Benchmark] public double StandardAuto() { var s = _values.AsSpan(); return _nativeTests.TestAddAuto(s); }
        [Benchmark] public double StandardInline() { var s = _values.AsSpan(); return _nativeTests.TestAddInline(s); }
        [Benchmark] public double StandardNoInline() { var s = _values.AsSpan(); return _nativeTests.TestAddNoInline(s); }

        [Benchmark] public double NativeAuto() { var s = _values.AsSpan(); return _standardTests.TestAddAuto(s); }
        [Benchmark] public double NativeInline() { var s = _values.AsSpan(); return _standardTests.TestAddInline(s); }
        [Benchmark] public double NativeNoInline() { var s = _values.AsSpan(); return _standardTests.TestAddNoInline(s); }


    }
}
