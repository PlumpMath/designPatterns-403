using System;
using DesignPatterns.Common.Base;
using DesignPatterns.Behavioral.Command;

namespace DesignPatterns.Patterns.PatternExecutor.Behavioral
{
    public class Command : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Encapsulate a request as an object, {0}thereby letting you parameterize clients with different requests, {0}queue or log requests, and support undoable operations. ", Environment.NewLine);
        }

        public string DescriptionPL()
        {
            return string.Empty;
        }

        public void Execute()
        {
            CommandBase command;
            IReciever calculator = new Calculator(10, 5);
            AddCommand accCommand = new AddCommand(calculator);
            SubstractCommand subCommand = new SubstractCommand(calculator);
            Multiply mulCommand = new Multiply(calculator);

            command = accCommand;
            Console.WriteLine(command.Execute());
            command = subCommand;
            Console.WriteLine(command.Execute());
            command = mulCommand;
            Console.WriteLine(command.Execute());

        }
    }
}
