using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class TimeWork
    {
        public static string TimeOfWorkList<T>(LinkedList<T> list, T obj)
        {
            bool flag;
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            flag = list.Contains(obj);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = $"{ts.TotalMilliseconds} Найден: {flag}";
            return elapsedTime;
        }
        public static string TimeOfWorkDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key)
        {
            bool flag;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            flag = dictionary.ContainsKey(key);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds.ToString() + $" Найден: {flag}";
        }
        public static string TimeOfWorkDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TValue value)
        {
            bool flag;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            flag = dictionary.ContainsValue(value);
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds.ToString() + $" Найден: {flag}";
        }
    }
}
