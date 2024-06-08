using Domain;
using System.Linq;
namespace CalculatorOperations
{
    public sealed class Subtraction : Operation
    {
        public Subtraction() : base("Вычитание") { }

        public override double Run(params double[] numbers) => numbers.Aggregate((a, b) => a - b);
    }
}
