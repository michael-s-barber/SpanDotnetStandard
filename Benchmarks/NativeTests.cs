using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Benchmarks
{
    public class NativeTests
    {
        public double TestAddAuto(Span<double> values)
        {
            double result = 0;
            for (int i = 0; i < values.Length; ++i)
                result += values[i];
            return result;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double TestAddInline(Span<double> values)
        {
            double result = 0;
            for (int i = 0; i < values.Length; ++i)
                result += values[i];
            return result;
        }


        [MethodImpl(MethodImplOptions.NoInlining)]
        public double TestAddNoInline(Span<double> values)
        {
            double result = 0;
            for (int i = 0; i < values.Length; ++i)
                result += values[i];
            return result;
        }
    }
}
