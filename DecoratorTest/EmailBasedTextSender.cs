using System;
using System.IO;

namespace DecoratorTest
{
    public class EmailBasedTextSender : ISendText
    {
        private readonly ISendText _sender;
        
        public EmailBasedTextSender(ISendText sender)
        {
            _sender = sender;
        }

        public void SendText(string textToSend)
        {
            _sender.SendText(textToSend);

            var id = Guid.NewGuid().ToString("D");
            
            File.WriteAllText(@"C:\temp\bus\EmailBasedTextSender" + id + ".txt", textToSend);
        }
    }
}