using Domain;
using System.Collections.Generic;

namespace Infrastructure
{
    public sealed class OperationProvider : IOperationProvider
    {
        private readonly IEnumerable<IOperation> operations;

        public OperationProvider(IEnumerable<IOperation> operations)
        {
            this.operations = operations;
        }

        public IEnumerable<IOperation> Get() => operations;
    }
}
