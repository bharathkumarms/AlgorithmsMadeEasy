using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.State
{
    public interface IState
    {
        public void DoAction();
    }

    public class TVOn : IState
    {
        public void DoAction()
        {
            Console.WriteLine("TV is on");
        }
    }

    public class TVOff : IState
    {
        public void DoAction()
        {
            Console.WriteLine("TV is off");
        }
    }

    public class TVContext : IState
    {
        private IState _state;

        public void SetState(IState state)
        {
            this._state = state;
            DoAction();
        }

        public void DoAction()
        {
            this._state.DoAction();
        }
    }
}
/*
    var context = new TVContext();
    var tvOn = new TVOn();
    var tvOff = new TVOff();

    context.SetState(tvOn);
    context.SetState(tvOff);

    Console.ReadLine();
 */
