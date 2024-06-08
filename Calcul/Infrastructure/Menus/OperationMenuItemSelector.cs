using System.Linq;
using Domain;

namespace Infrastructure
{
    public sealed class OperationMenuItemSelector : IOperationMenuItemSelector
    {
        private readonly IMenuItemSelectorProvider selector;
        private readonly IOperationProvider operationProvider;

        public OperationMenuItemSelector(IMenuItemSelectorProvider selector, IOperationProvider operationProvider)
        {
            this.selector = selector;
            this.operationProvider = operationProvider;
        }

        public IOperation Select()
        {
            int id = selector.GetMenuItemId();
            return id > 0 ? operationProvider.Get().ElementAtOrDefault(id - 1) : null;
        }
    }
}

