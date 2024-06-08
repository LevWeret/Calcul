using Domain;
using System;
namespace CalculatorOperations
{
    public sealed class SquareRoot : Operation
    {
        public SquareRoot() : base("Корень из числа") { }

        public override double Run(params double[] numbers) => Math.Sqrt(numbers[0]);
    }
}

