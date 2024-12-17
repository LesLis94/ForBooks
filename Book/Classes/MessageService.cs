using System;
using Book.Interfaces;

namespace Book.Classes

{
	public class MessageService
	{
        // один класс должен заниматься одной задачей

        // private readonly EmailService _emailService = new EmailService();
        //private readonly IMessageService _messageService = new EmailService();
        private readonly IMessageService _messageService;

        public MessageService(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify()
		{
            // var emailService = new EmailService();
            _messageService.SendMessage("Hello");
		}

        public void NotifyAll()
        {
            //var emailService = new EmailService();
            _messageService.SendMessage("Hi");
        }
    }




    public class EmailService : IMessageService
    {
        private ILogger _logger;
        private IDataBase _dataBase;

        public EmailService(ILogger logger, IDataBase dataBase)
        {
            _logger = logger;
            _dataBase = dataBase;
        }

        public void SendMessage(string messege)
        {
            Console.WriteLine("Email: " + messege);

            _logger.Log("Залогированно");

            _dataBase.Save();
        }

    }



    public class TelegramService : IMessageService
    {
        public void SendMessage(string messege)
        {
            Console.WriteLine("Telegram: " + messege);

        }

    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class PostgresDataBase : IDataBase
    {

        private readonly ILogger _logger;

        public PostgresDataBase(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Изменения сохранены");
            _logger.Log("Операция прошла успешно");
        }
    }


}