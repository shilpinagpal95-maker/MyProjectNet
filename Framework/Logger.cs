using System;

namespace Framework
{
    public static class Logger
    {
        public static void Log(string message) => Console.WriteLine($"[LOG] {message}");
    }
}
