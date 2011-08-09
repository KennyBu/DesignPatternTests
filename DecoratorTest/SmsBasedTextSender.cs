using System;
using System.IO;

namespace DecoratorTest
{
    public class SmsBasedTextSender : ISendText
    {
        private readonly ISendText _sender;

        public SmsBasedTextSender(ISendText sender)
        {
            _sender = sender;
        }

        public void SendText(string textToSend)
        {
            _sender.SendText(textToSend);

            var id = Guid.NewGuid().ToString("D");

            File.WriteAllText(@"C:\temp\bus\SmsbasedTextSender" + id + ".txt", textToSend);
        }
    }
}