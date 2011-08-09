using System;
using System.IO;

namespace DecoratorTest
{
    public class FileBasedTextSender : ISendText
    {
        public void SendText(string textToSend)
        {
            var id = Guid.NewGuid().ToString("D");

            File.WriteAllText(@"C:\temp\bus\FileBasedTextSender" + id + ".txt", textToSend);
        }
    }
}