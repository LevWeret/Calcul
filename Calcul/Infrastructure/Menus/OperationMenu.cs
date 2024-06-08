using Domain;
using System;

namespace Infrastructure
{
    public sealed class OperationMenu : IMenu<IOperation>
    {
        private readonly IOperationProvider operationProvider;

        public OperationMenu(IOperationProvider operationProvider, IOperationMenuItemSelector menuItemSelector)
        {
            this.operationProvider = operationProvider;
            ItemSelector = menuItemSelector;
        }

        public IMenuItemSelector<IOperation> ItemSelector { get; }

        public IMenu<IOperation> Show()
        {
            Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
            int i = 1;
            foreach (var operation in operationProvider.Get())
            Console.WriteLine($"{i++}.{operation.Name}");
            return this;
        }
    }
}





