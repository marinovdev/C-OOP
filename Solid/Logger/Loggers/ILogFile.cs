
namespace ex01.Loggers
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
