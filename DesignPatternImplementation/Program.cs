using DesignPatternImplementation.ChainOfResponsibilities;
using DesignPatternImplementation.CommandDP;
using DesignPatternImplementation.Interpreter;
using DesignPatternImplementation.Iterator;
using DesignPatternImplementation.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediatorObj = new MediatorImpl();
            var u1 = new UserImpl(mediatorObj, "Bharath");
            var u2 = new UserImpl(mediatorObj, "Kumar");
            var u3 = new UserImpl(mediatorObj, "Ganesh");
            mediatorObj.AddUser(u1);
            mediatorObj.AddUser(u2);
            mediatorObj.AddUser(u3);
            u1.Send("Hello");

            u2.Send("Cool");

            Console.ReadLine();
        }
    }
}
