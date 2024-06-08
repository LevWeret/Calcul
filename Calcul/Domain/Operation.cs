namespace Domain
{
    public abstract class Operation : IOperation
    {
        public string Name { get; }

        protected Operation(string name)
        {
            Name = name;
        }

        public abstract double Run(params double[] numbers);
    }
}
