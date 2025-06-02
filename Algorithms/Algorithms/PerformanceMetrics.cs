using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Algorithms
{
    public class PerformanceMetrics
    {
        public static TimeSpan MeasurePerformance(Action action)
        {
            // قياس الوقت
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // تنفيذ الإجراء
            action();

            stopwatch.Stop();

            // قياس الكلفة المكانية
            long memorySize = GetMemorySize(action.Target);

            return stopwatch.Elapsed;
        }

        public static (TimeSpan elapsedTime, TResult result) MeasurePerformance<TResult>(Func<TResult> func)
        {
            // قياس الوقت
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // تنفيذ الإجراء
            TResult result = func();

            stopwatch.Stop();

            // قياس الكلفة المكانية
            long memorySize = GetMemorySize(func.Target);

            return (stopwatch.Elapsed, result);
        }

        public static (TimeSpan elapsedTime, TResult result) MeasurePerformance<T1, TResult>(Func<T1, TResult> func, T1 arg1)
        {
            // قياس الوقت
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // تنفيذ الإجراء
            TResult result = func(arg1);

            stopwatch.Stop();

            // قياس الكلفة المكانية
            long memorySize = GetMemorySize(func.Target);

            return (stopwatch.Elapsed, result);
        }



        // Method لحساب الحجم في الذاكرة
        private static long GetMemorySize(object obj)
        {
            long size = 0;
            if (obj != null)
            {
                Type type = obj.GetType();
                FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

                foreach (var field in fields)
                {
                    if (field.FieldType.IsValueType)
                    {
                        size += Marshal.SizeOf(field.FieldType);
                    }
                    else
                    {
                        size += IntPtr.Size; // حجم الإشارة للكائنات المرجعية
                    }
                }
            }
            return size;
        }
    }
}

