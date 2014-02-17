/*
    Author: Matt Nedrich
    mattnedrich@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace mattnedrich.tools
{
    public static class Benchmarker
    {
        public static TimeSpan RunOnce(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        public static IList<TimeSpan> RunMany(Action action, int runCount)
        {
            List<TimeSpan> results = new List<TimeSpan>();
            for (int i = 0; i < runCount; i++)
                results.Add(RunOnce(action));
            return results;
        }
    }
}
