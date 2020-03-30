using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Memento
{
    //Originator, memento and caretaker
    public class TimeMachine
    {
        private string time;

        public void Set(string time)
        {
            Console.WriteLine("Setting time to " + time);
            this.time = time;
        }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Saving time to memento");
            return new Memento(time);
        }

        public void Restore(Memento m)
        {
            time = m.Get();
            Console.WriteLine("Time restored from memento: " + time);
        }


        public class Memento
        {
            private readonly string _time;

            public Memento(string time)
            {
                _time = time;
            }

            public string Get()
            {
                return _time;
            }
        }

    }
}
/*
    //The names of some variable is cut shot to focus on concepts than standards.
    //When you try at home or office, please follow all the coding standards.

    var tm = new TimeMachine();
    var careTaker = new List<TimeMachine.Memento>();

    tm.Set("1000 BC");
    careTaker.Add(tm.SaveToMemento());

    tm.Set("1000 AD");
    careTaker.Add(tm.SaveToMemento());

    tm.Set("2000 AD");
    careTaker.Add(tm.SaveToMemento());

    tm.Restore(careTaker[1]);
 */
