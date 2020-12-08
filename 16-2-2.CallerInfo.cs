using System;
using System.Runtime.CompilerServices;

namespace CallerInfo
{
    public static class Trace
    {
        public static void Writeline(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine($"{file}(Line:{line}) {member}: {message}");
        }
    }

    class MainApp
    {
        static void Main(string[]args)
        {
            Trace.Writeline("즐거운 프로그래밍");
        }
    }
}
    
