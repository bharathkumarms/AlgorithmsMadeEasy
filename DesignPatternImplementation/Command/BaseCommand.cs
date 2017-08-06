using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Command
{
    public interface IAppCommand
    {
        StringBuilder sb { get; set; }
        void Execute(string text);
        void UnExecute();
    }

    public abstract class BaseCommand : IAppCommand
    {
        public StringBuilder sb { get; set; }
        protected readonly List<string> Entries = new List<string>();
        public abstract void Execute(string text);
        public abstract void UnExecute();
    }
}
