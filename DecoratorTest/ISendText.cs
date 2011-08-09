using System;

namespace DecoratorTest
{
    public interface ISendText
    {
        void SendText(string textToSend);
    }

    public interface ISendEmailText : ISendText
    {
        
    }
}