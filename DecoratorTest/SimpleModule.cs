using System.Linq;
using Ninject.Modules;

namespace DecoratorTest
{
    public class SimpleModule : NinjectModule
    {
        public override void Load()
        {
            //Default ISendText - use the EmailBasedTextSender
            Bind<ISendText>().To<EmailBasedTextSender>();

            //Decorator - When you see an EmailBasedTextSender then inject into it
            //the FileBasedTextSender
            Bind<ISendText>().To<FileBasedTextSender>()
                .WhenInjectedInto<EmailBasedTextSender>();

            //When a ISendText is requested and we are injected into a class
            // that implemenets the IFileInterface use a FileBasedTextSender
            //and forget about the email based decorator injection
            
            Bind<ISendText>().To<FileBasedTextSender>()
                .When(x => typeof(IFileInterface)
                    .IsAssignableFrom(x.ActiveBindings.FirstOrDefault().Service));

            Bind<Scenario1>().ToSelf();
            Bind<Scenario2>().ToSelf();
        }
    }
}