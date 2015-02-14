﻿using System;

namespace Test
{
    public static class Log
    {
        public static void Write(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void WriteFormat(string msgFormat, params object[] args)
        {
            string formattedString = string.Format(msgFormat, args);
            Console.WriteLine(formattedString);
        }

        public static void WriteLineFormat(string msgFormat, params object[] args)
        {
            string formattedString = string.Format(msgFormat, args);
            Console.WriteLine(formattedString);
            Console.WriteLine();
        }

        public static void WriteStringLine()
        {
            Console.WriteLine(new string('-', 30));
        }

        public static void WriteLine()
        {
            Console.WriteLine();
        }
    }
}