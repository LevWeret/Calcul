using Domain;
using System.Linq;
namespace CalculatorOperations
{
    public sealed class Multiplication : Operation
    {
        public Multiplication() : base("Умножение") { }

        public override double Run(params double[] numbers) => numbers.Aggregate((a, b) => a * b);
    }
}