using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Command
{
    public class Controller
    {
        private readonly List<IAppCommand> _commands = new List<IAppCommand>();
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public int AddCommand(IAppCommand cmd)
        {
            cmd.sb = _stringBuilder;
            _commands.Add(cmd);
            return _commands.IndexOf(cmd);
        }

        public IAppCommand GetCommandAt(int index)
        {
            return _commands[index];
        }

        public string GetBuiltString()
        {
            return _stringBuilder.ToString();
        }
    }
}
