using System.Collections.Generic;

namespace DesignPatterns
{
    public class WorkQueue
    {
        private readonly IList<ICommand> Commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            Commands.Add(command);
        }

        public void Proccess()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
