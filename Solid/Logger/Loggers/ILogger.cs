using ex01.Appenders;
namespace ex01.Loggers
{
    public interface ILogger
    {
        public IAppender[] Appenders { get;}

        void Error(string dateTime, string message);

        void Info(string dateTime, string message);
    }
}
