﻿namespace SingleTon
{
    partial class Program
    {
        public interface ILogWriter
        {
            void LogInfo(string message);
            void LogWarning(string message);
            void LogError(string message);
        }
    }
}
