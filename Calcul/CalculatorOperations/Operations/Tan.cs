using Domain;
using System;
namespace CalculatorOperations
{
    public sealed class Tan : Operation
    {
        public Tan() : base("Тангенс") { }

        public override double Run(params double[] numbers) => Math.Tan(numbers[0]);
    }
}
