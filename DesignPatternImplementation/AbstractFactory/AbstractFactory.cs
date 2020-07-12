using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.AbstractFactoryDesignPattern
{
    public interface IMode
    {
        void On();
    }

    public class NormalMode : IMode
    {
        public void On()
        {
            Console.WriteLine("On in normal mode.");
        }
    }

    public class SafeMode : IMode
    {
        public void On()
        {
            Console.WriteLine("On in safe mode.");
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IMode Mode();
    }

    public class NormalFactory : AbstractFactory
    {
        public override IMode Mode()
        {
            return new NormalMode();
        }
    }

    public class SafeFactory : AbstractFactory
    {
        public override IMode Mode()
        {
            return new SafeMode();
        }
    }

    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool isNormal)
        {
            if (isNormal)
            {
                return new NormalFactory();
            }

            return new SafeFactory();
        }
    }
}

/*
    AbstractFactory factory = FactoryProducer.GetFactory(false);

    IMode mode = factory.Mode();
    mode.On();

    Console.ReadLine();
*/
