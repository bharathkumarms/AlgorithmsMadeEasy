using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Adapter
{
    public interface ITarget
    {
        string GetInformation();
    }

    class Adaptee
    {
        public string GetMoreInformation()
        {
            return "More Information";
        }
    }

    class UniversalAdapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public UniversalAdapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public string GetInformation()
        {
            return this._adaptee.GetMoreInformation();
        }
    }
}

/*
    var adaptee = new Adaptee();
    var target = new UniversalAdapter(adaptee);

    Console.WriteLine(target.GetInformation());

    Console.ReadLine();
 */
