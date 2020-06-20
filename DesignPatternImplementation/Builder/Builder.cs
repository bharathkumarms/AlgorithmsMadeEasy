using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Builder
{
    public class SMS
    {
        public string to;
        public string message;

        public SMS(string to, string message)
        {
            this.to = to;
            this.message = message;
        }

        public void Send()
        {
            // telecommunication
            Console.WriteLine(message + " sent to " + to);
        }

        public class SMSBuilder
        {
            public string recipient;
            public string message;
            public SMSBuilder AddRecipient(string name)
            {
                this.recipient = name;
                return this;
            }

            public SMSBuilder AddMessage(string message)
            {
                this.message = message;
                return this;
            }

            public SMS Build()
            {
                return new SMS(recipient, message);
            }
        }
    }
}
/*
    var sms = new SMS.SMSBuilder()
                    .AddRecipient("9999999999")
                    .AddMessage("Hello")
                    .Build();

    sms.Send();

    Console.ReadLine();
*/
