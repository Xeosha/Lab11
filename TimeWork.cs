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
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var flag = list.Contains(obj);
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds.ToString() + $" Найден: {flag}";
        }
        public static string TimeOfWorkDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key) where TKey: notnull
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var flag = dictionary.ContainsKey(key);
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds.ToString() + $" Найден: {flag}";
        }
        public static string TimeOfWorkDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TValue value) where TKey : notnull
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var flag = dictionary.ContainsValue(value);
            stopWatch.Stop();
            return stopWatch.Elapsed.TotalMilliseconds.ToString() + $" Найден: {flag}";
        }
    }
}
