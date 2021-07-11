using Atlanta.Domain;
using MassTransit;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Atlanta.Consumer.Consumers
{
    internal class GodsConsumer : IConsumer<Gods>
    {
        private readonly ILogger<GodsConsumer> logger;

        public GodsConsumer(ILogger<GodsConsumer> logger)
        {
            this.logger = logger;
        }

        public async Task Consume(ConsumeContext<Gods> context)
        {
            await Console.Out.WriteLineAsync(context.Message.Name);
            logger.LogInformation($"Got new message {context.Message.Name}");
        }
    }
}
