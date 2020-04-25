using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Decorator
{
    public abstract class Pizza
    {
        public string name = "No Name";

        public virtual string GetName()
        {
            return name;
        }

        public abstract int Cost();
    }

    public abstract class Decorator : Pizza
    {
        public abstract new string GetName();
    }

    public class FarmHouse : Pizza
    {
        public FarmHouse()
        {
            name = "FarmHouse";
        }
        public override int Cost()
        {
            return 200;
        }
    }

    public class Margherita : Pizza
    {
        public Margherita()
        {
            name = "Margherita";
        }
        public override int Cost()
        {
            return 100;
        }
    }

    public class Tomato : Decorator
    {
        private readonly Pizza _pizza;

        public Tomato(Pizza pizza)
        {
            _pizza = pizza;
        }
        public override int Cost()
        {
            return _pizza.Cost() + 50;
        }

        public override string GetName()
        {
            return _pizza.GetName() + ", Tomato";
        }
    }
}
/*
var pizza = new Margherita();

var iWantMore = new Tomato(pizza);

Console.WriteLine(iWantMore.GetName() + " " + iWantMore.Cost());

Console.ReadLine();
*/
