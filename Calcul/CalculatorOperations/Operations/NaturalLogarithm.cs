using Domain;
using System;
namespace CalculatorOperations
{
    public sealed class NaturalLogarithm : Operation
    {
        public NaturalLogarithm() : base("Натуральный логарифм (ln)") { }

        public override double Run(params double[] numbers) => Math.Log(numbers[0]);
    }
}
