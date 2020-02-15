using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.CommandDP
{
    public interface ICommand
    {
        string Name { get; }
        void Execute();
    }

    public class StartCommand : ICommand
    {
        public string Name
        {
            get
            {
                return "Start";
            }
        }

        public void Execute()
        {
            Console.WriteLine("Started");
        }
    }

    public class StopCommand : ICommand
    {
        public string Name
        {
            get
            {
                return "Stop";
            }
        }

        public void Execute()
        {
            Console.WriteLine("Stopped");
        }
    }

    public class Invoker
    {
        ICommand cmd = null;
        public ICommand GetCommand(string action)
        {
            switch(action)
            {
                case "Start":
                    cmd = new StartCommand();
                    break;
                case "Stop":
                    cmd = new StopCommand();
                    break;
                default:
                    break;
            }

            return cmd;
        }
    }
}

/*
 *  Invoker i = new Invoker();
    ICommand c = i.GetCommand("Start");
    c.Execute();

    ICommand c1 = i.GetCommand("Stop");
    c1.Execute();

    Console.ReadLine();
 */
