using LINQ.Models;
using System;

namespace LINQ
{
    public abstract class LinqMethod
    {
        protected Car[] Cars { get; }

        public LinqMethod(Car[] v)
        {
            Cars = v;
        }

        public bool Execute()
        {
            Console.WriteLine($"{ GetType().Name}- started");

            if (!ExecuteStep("ExecuteCore", ExecuteCore)) return false;

            Console.WriteLine($"{GetType().Name}- finished");
            return true;
        }

        private bool ExecuteStep(string linqMethodName, Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                PrintExceptionMessage(ex.Message);
            }

            return true;
        }

        protected abstract void ExecuteCore();

        private void PrintExceptionMessage(string message)
        {
            PrintMessage(message, ConsoleColor.Red);
        }

        private void PrintMessage(string message)
        {
            PrintMessage(message, ConsoleColor.White);
        }

        private void PrintMessage(string message, ConsoleColor color)
        {
            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.WriteLine("\t" + message);

            Console.ForegroundColor = currentColor;
        }
    }
}
