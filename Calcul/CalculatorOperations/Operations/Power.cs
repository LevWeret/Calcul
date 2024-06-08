using Domain;
using System;
namespace CalculatorOperations
{
    public sealed class Power : Operation
    {
        public Power() : base("Возведение в степень") { }

        public override double Run(params double[] numbers) => Math.Pow(numbers[0], numbers[1]);
    }
}

