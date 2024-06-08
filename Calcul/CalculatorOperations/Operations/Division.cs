using Domain;
using System.Linq;
using System;
namespace CalculatorOperations
{
    public sealed class Division : Operation
    {
        public Division() : base("Деление") { }

        public override double Run(params double[] numbers)
        {
            if (numbers.Length < 2 || numbers[1] == 0)
            {
                throw new DivideByZeroException("Деление на ноль или отсутствие второго числа.");
            }

            return numbers.Aggregate((a, b) => a / b);
        }
    }
}

