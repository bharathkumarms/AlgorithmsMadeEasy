using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.ChainOfResponsibilities
{
    public interface Chain
    {
        public abstract void SetNext(Chain nextInChain);
        public abstract void Process(Number request);
    }

    public class Number
    {
        private int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int GetNumber()
        {
            return number;
        }
    }

   public class PositiveChain : Chain
    {
        private Chain chain;

        public void Process(Number request)
        {
            if (request.GetNumber() > 0)
            {
                Console.WriteLine("I'm Positive");
            }
            else
            {
                chain.Process(request);
            }
        }

        public void SetNext(Chain nextInChain)
        {
            chain = nextInChain;
        }
    }

    public class ZeroChain : Chain
    {
        private Chain chain;

        public void Process(Number request)
        {
            if (request.GetNumber() == 0)
            {
                Console.WriteLine("I'm Zero");
            }
            else
            {
                chain.Process(request);
            }
        }

        public void SetNext(Chain nextInChain)
        {
            chain = nextInChain;
        }
    }

    public class NegativeChain : Chain
    {
        private Chain chain;

        public void Process(Number request)
        {
            if (request.GetNumber() < 0)
            {
                Console.WriteLine("I'm Negative");
            }
            else
            {
                chain.Process(request);
            }
        }

        public void SetNext(Chain nextInChain)
        {
            chain = nextInChain;
        }
    }
}
/*
 *  var c = new PositiveChain();
    var c1 = new NegativeChain();
    var c2 = new ZeroChain();
    c.SetNext(c1);
    c1.SetNext(c2);

    c.Process(new Number(1));
    c.Process(new Number(-1));
    c.Process(new Number(0));
    c.Process(new Number(1000));

    Console.ReadLine();
 */
