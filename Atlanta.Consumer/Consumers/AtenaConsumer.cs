using Atlanta.Domain;
using MassTransit;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Atlanta.Consumer.Consumers
{
    internal class AtenaConsumer : IConsumer<Atena>
    {
        private readonly ILogger<AtenaConsumer> logger;

        public AtenaConsumer(ILogger<AtenaConsumer> logger)
        {
            this.logger = logger;
        }

        public async Task Consume(ConsumeContext<Atena> context)
        {
            await Console.Out.WriteLineAsync(context.Message.Name);
            logger.LogInformation($"Got new message {context.Message.Name}");
        }
    }
}
