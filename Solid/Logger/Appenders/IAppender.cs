
using ex01.Enums;
using ex01.Layouts;

namespace ex01.Appenders
{
    public interface IAppender
    {
        public ILayout Layout { get;}

        void Append(string dateTime, ReportLevel logLevel, string message);
    }
}
