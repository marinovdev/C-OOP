
namespace CommandPattern
{
using CommandPattern.Core.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        public CommandInterpreter()
        {
            Command = new HelloCommand();
        }

        public CommandInterpreter(ICommand command)
        {
            Command = command;
        }

        public string Read(string args)
        {
            var inputArgs = args.Split(' ');
            var order = inputArgs[0];

            var commandArgs = inputArgs.Skip(1).ToArray();
            var result = string.Empty;
            ICommand command = null;

            var commandType = Assembly.GetCallingAssembly()
                .GetTypes().FirstOrDefault(n => n.Name.ToLower() == order.ToLower() + "command"); // returns object

            if (commandType == null) throw new ArgumentException("Invalid command type!");

            ICommand intanceType = Activator.CreateInstance(commandType) as ICommand; // casting the object to ICommand

            if (intanceType == null) throw new ArgumentException("Invalid command type!");

            result = intanceType.Execute(commandArgs);
            return result;
        }

        public ICommand Command { get; set; }
    }
}
