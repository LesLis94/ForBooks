using System;
namespace Book.Interfaces
{
	public interface IMessageService
	{

		void SendMessage(string message);

	}

	public interface ILogger
	{
		void Log(string message);
	}


    public interface IDataBase
    {
        void Save();
    }

}

