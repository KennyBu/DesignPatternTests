using Ninject;
using Ninject.Modules;

namespace DecoratorTest
{
    class Program
    {
        private static IKernel kernel;
        
        static void Main()
        {
            const string message = "Ground control to Major Tom!";
            
            NinjectModule module = new SimpleModule();
            kernel = new StandardKernel(module);

            var scenario1 = kernel.Get<Scenario1>();
            var scenario2 = kernel.Get<Scenario2>();

            scenario1.SendTheMessageYo(message);
            scenario2.SendTheMessageYo(message);
        }
    }
}
