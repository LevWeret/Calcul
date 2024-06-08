using System.Linq;
using Domain;

namespace CalculatorOperations
{
    public sealed class Addition : Operation
    {
        public Addition() : base("Сложение") { }

        public override double Run(params double[] numbers) => numbers.Sum();
    }
}
