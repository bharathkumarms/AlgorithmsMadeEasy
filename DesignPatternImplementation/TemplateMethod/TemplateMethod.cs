using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.TemplateMethod
{
    public abstract class OrderTemplate
    {
        public abstract void Choose();
        public abstract void Pay();
        public abstract void Deliver();

        public bool isMember;

        public void Discount()
        {
            Console.WriteLine("Additional 10% discount processed for member");
        }

        public void Process(bool isMember)
        {
            Choose();
            if (isMember)
            {
                Discount();
            }
            Pay();
            Deliver();
        }
    }

    public class Online : OrderTemplate
    {
        public override void Choose()
        {
            Console.WriteLine("Product selected online.");
        }

        public override void Deliver()
        {
            Console.WriteLine("Product delivered(online).");
        }

        public override void Pay()
        {
            Console.WriteLine("Paid online.");
        }
    }

    public class Offline : OrderTemplate
    {
        public override void Choose()
        {
            Console.WriteLine("Product selected offine.");
        }

        public override void Deliver()
        {
            Console.WriteLine("Product delivered(offline).");
        }

        public override void Pay()
        {
            Console.WriteLine("Paid offline.");
        }
    }
}

/*
    var onlineOrder = new Online();
    onlineOrder.Process(true);

    Console.WriteLine();

    var offlineOrder = new Offline();
    offlineOrder.Process(false);
 */
