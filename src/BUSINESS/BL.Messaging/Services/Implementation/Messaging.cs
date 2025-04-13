using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using hmw.src.DATA.DATA.SQL.Entities;
using hmw.src.DATA.DATA.SQL.Services;
using hmw.src.DATA.DATA.SQL.Services.Implementation;

namespace hmw.src.BUSINESS.BL.Messaging.Services.Implementation
{
    internal class Messaging : IMessaging
    {
        public void Publish(Message message)
        {
            if (string.IsNullOrWhiteSpace(message.text))
            {
                Console.WriteLine("Invalid message received.");
                return;
            }
            Console.WriteLine($"Processing message: {message.text}");
            MessageService messageService = new MessageService();
            messageService.saveMessage(message);
        }
    }
}
