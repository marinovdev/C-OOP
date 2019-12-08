
namespace CommandPattern
{
using CommandPattern.Core.Contracts;
using System;
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            while (true)
            {
                var input = Console.ReadLine();
                var output = this.CommandInterpreter.Read(input);
                Console.WriteLine(output);
            }
        }

        public ICommandInterpreter CommandInterpreter { get => commandInterpreter; }
    }
}
