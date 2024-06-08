using Domain;
using System;
namespace CalculatorOperations
{
    public sealed class Cotan : Operation
    {
        public Cotan() : base("Котангенс") { }

        public override double Run(params double[] numbers) => 1 / Math.Tan(numbers[0]);
    }
}
