
namespace CommandPattern
{
    using CommandPattern.Core.Contracts;
    using System.Linq;
    using System.Reflection;
    using CommandPattern.Core;
    using System;
    using System.Threading;

    public class StartUp
    {
        public static void Main()
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
        }
    }
}
