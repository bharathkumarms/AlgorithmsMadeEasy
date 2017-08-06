using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Command
{
    public class AddTextCommand : BaseCommand
    {
        public override void Execute(string text)
        {
            sb.Append(text);
            Entries.Add(text);
        }

        public override void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
