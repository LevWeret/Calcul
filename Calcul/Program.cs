using System;
using Castle.Windsor;
using Castle.Facilities.Startable;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;

namespace Infrastructure
{
    public class Program
    {
        private static IWindsorContainer _container = new WindsorContainer();

        public static void Main()
        {
            try
            {
                Start();
                Console.WriteLine("Программа запущена. Нажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                _container?.Dispose();
            }
        }

        private static void Start()
        {
            _container.Kernel.AddFacility<StartableFacility>(f => f.DeferredStart());
            _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel));
            _container.Install(new LocalInstaller());

            var application = _container.Resolve<Application>();
            application.Run();
        }
    }
}
