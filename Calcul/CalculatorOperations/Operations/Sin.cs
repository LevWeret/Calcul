using Domain;
using System;
namespace CalculatorOperations
{
    public sealed class Sin : Operation
    {
        public Sin() : base("Синус") { }

        public override double Run(params double[] numbers) => Math.Sin(numbers[0]);
    }
}
