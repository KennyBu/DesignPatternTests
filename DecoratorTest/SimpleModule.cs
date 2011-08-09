using System.Linq;
using Ninject.Modules;

namespace DecoratorTest
{
    public class SimpleModule : NinjectModule
    {
        public override void Load()
        {
            //Default
            Bind<ISendText>().To<EmailBasedTextSender>();

            //Decorator - when you see an email based then inject in the file based
            Bind<ISendText>().To<FileBasedTextSender>()
                .WhenInjectedInto<EmailBasedTextSender>();

            //When a FileBased is requested and we are injected into a IFileInterface class use just a
            //file based and forget about the email based decorator injection
            
            Bind<ISendText>().To<FileBasedTextSender>()
                .When(x => typeof(IFileInterface)
                    .IsAssignableFrom(x.ActiveBindings.FirstOrDefault().Service));

            Bind<Scenario1>().ToSelf();
            Bind<Scenario2>().ToSelf();
        }
    }
}