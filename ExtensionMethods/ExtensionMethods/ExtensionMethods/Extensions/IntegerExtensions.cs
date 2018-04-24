using System;

namespace ExtensionMethods.Extensions
{
    public static class IntegerExtensions
    {
        public static int Add(this int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static int Subtract(this int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static int Multiply(this int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public static int Divide(this int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException($"Second number cannot be zero");

            return firstNumber / secondNumber;
        }
        public static int Max(this int firstNumber, int secondNumber)
        {
            return firstNumber >= secondNumber ? firstNumber : secondNumber;
        }
        public static int Min(this int firstNumber, int secondNumber)
        {
            return firstNumber <= secondNumber ? firstNumber : secondNumber;
        }
    }
}
