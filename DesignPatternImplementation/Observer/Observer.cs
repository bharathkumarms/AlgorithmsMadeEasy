using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Observer
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Update();
    }

    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void NotifyAllObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update();
            }
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
    }

    public class HexObserver : Observer
    {
        public readonly Subject _subject;

        public HexObserver(Subject subject)
        {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("The hex value is:" + _subject.GetState().ToString("X"));
        }
    }

    public class BinaryObserver : Observer
    {
        public readonly Subject _subject;

        public BinaryObserver(Subject subject)
        {
            this._subject = subject;
            this._subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("The binary value is:" + Convert.ToString(_subject.GetState(),2));
        }
    }
}
/*
    Subject subject = new Subject();
    new HexObserver(subject);
    new BinaryObserver(subject);

    subject.SetState(10);

    subject.SetState(20);
 */
