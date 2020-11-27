using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFireApplication.Services
{
    public class MessageService : IServiceBase<MessageService>
    {
        private readonly ILogger<MessageService> _logger;
        public MessageService(ILogger<MessageService> logger)
        {
            _logger = logger;
        }
        public Task Start()
        {
            _logger.LogInformation($"Começando o serviço iniciado pelo hangfire { DateTime.Now }");

            Console.WriteLine("  Executando as tarefas que tem que executar   ");

            return Task.CompletedTask.ContinueWith(a =>
            {
                Stop();
            });
        }

        public Task Stop()
        {
            Console.WriteLine("  Executando a ultima tarefa antes de terminar   ");

            _logger.LogInformation($"Terminado a execução do serviço do hangfire { DateTime.Now }");

            return Task.CompletedTask;
        }
    }
}
