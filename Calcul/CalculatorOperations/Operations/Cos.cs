using Domain;
using System;
namespace CalculatorOperations
{
    public sealed class Cos : Operation
    {
        public Cos() : base("Косинус") { }

        public override double Run(params double[] numbers) => Math.Cos(numbers[0]);
    }
}

