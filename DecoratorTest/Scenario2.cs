namespace DecoratorTest
{
    public class Scenario2 : IEmailInterface
    {
        private readonly ISendText _textSender;

        public Scenario2(ISendText textSender)
        {
            _textSender = textSender;
        }

        public void SendTheMessageYo(string theMessage)
        {
            _textSender.SendText(theMessage);
        }
    }
}