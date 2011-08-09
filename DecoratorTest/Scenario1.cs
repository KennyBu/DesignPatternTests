namespace DecoratorTest
{
    public class Scenario1 : IFileInterface
    {
        private readonly ISendText _textSender;

        public Scenario1(ISendText textSender)
        {
            _textSender = textSender;
        }

        public void SendTheMessageYo(string theMessage)
        {
            _textSender.SendText(theMessage);
        }
    }
}