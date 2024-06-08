using System;
using Domain;

namespace CalculatorOperations
{
    public sealed class DecimalLogarithm : Operation
    {
        public DecimalLogarithm() : base("Десятичный логарифм (log10)") { }

        public override double Run(params double[] numbers) => Math.Log10(numbers[0]);
    }
}
