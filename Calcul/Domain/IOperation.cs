namespace Domain
{
    public interface IOperation
    {
        string Name { get; }
        double Run(params double[] numbers);
    }
}