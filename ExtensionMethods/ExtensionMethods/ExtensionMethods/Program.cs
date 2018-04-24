using ExtensionMethods.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 10;
            var secondNumber = 20;
            List<string> list = new List<string>();
           
            Console.WriteLine("Integer Extensions\n__________________");
            Console.WriteLine("Add:"+firstNumber.Add(secondNumber));
            Console.WriteLine("Subtract:" + firstNumber.Subtract(secondNumber));
            Console.WriteLine("Multiply:" + firstNumber.Multiply(secondNumber));
            Console.WriteLine("Divide:" + firstNumber.Divide(secondNumber));
            Console.WriteLine("Max:" + firstNumber.Max(secondNumber));
            Console.WriteLine("Min:" + firstNumber.Min(secondNumber));

            var str = "This is a very long post.This post is there to continue......";  
            Console.WriteLine("GetFirstNWords:" + str.GetFirstNWords(3));

            Console.Read();
        }
    }
}
