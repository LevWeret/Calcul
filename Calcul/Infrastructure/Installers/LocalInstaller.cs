using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Facilities.Startable;
using Domain;
using CalculatorOperations;

namespace Infrastructure
{
    internal class LocalInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IWindsorContainer>().Instance(container),
                Component.For<Application>().LifestyleSingleton().Start(),

                Component.For<IOperationMenuItemSelector>().ImplementedBy<OperationMenuItemSelector>().LifestyleTransient(),
                Component.For<IMenuItemSelectorProvider>().ImplementedBy<OperationMenuItemSelectorView>().LifestyleTransient(),
                Component.For<IOperationProvider>().ImplementedBy<OperationProvider>().LifestyleSingleton(),
                Component.For<IMenu<IOperation>>().ImplementedBy<OperationMenu>().LifestyleTransient(),

                Component.For<IOperation>().ImplementedBy<Addition>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<Subtraction>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<Multiplication>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<Division>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<Power>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<SquareRoot>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<Sin>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<Cos>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<Tan>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<Cotan>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<NaturalLogarithm>().LifestyleTransient(),
                Component.For<IOperation>().ImplementedBy<DecimalLogarithm>().LifestyleTransient()
            );
        }
    }
}




