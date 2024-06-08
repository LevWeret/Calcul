using System.Collections.Generic;
namespace Domain
{
    public interface IOperationProvider
    {
        IEnumerable<IOperation> Get();
    }
}
