using NATS.Client.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using hmw.src.DATA.DATA.SQL.Entities;
using hmw.src.BUSINESS.BL.Messaging;
using hmw.src.BUSINESS.BL.Messaging.Services;
using hmw.src.BUSINESS.BL.Messaging.Services.Implementation;

namespace hmw.src.API
{
    class Program
    {
        static async void Main()
        {
            await using var connection = new NatsConnection(new NatsOpts { Url = "0.0.0.0:4222" });

            await foreach (var msg in connection.SubscribeAsync<string>("messages.new"))
            {
                var message = JsonSerializer.Deserialize<Message>(msg.Data);
                Console.WriteLine($"Received: {message.text}");
                Messaging messaging = new Messaging();
                messaging.Publish(message);
            }

        }
    }
}
