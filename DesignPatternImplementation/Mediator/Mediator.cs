using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Mediator
{
    public interface Mediator
    {
        public void BroadcastMessage(string msg, User user);
        void AddUser(User user);
    }

    public abstract class User
    {
        protected Mediator _mediator;
        protected string _name;

        public User(Mediator m, string name)
        {
            _mediator = m;
            _name = name;
        }
        public abstract void Send(String msg);

        public abstract void Receive(String msg);
    }

    public class MediatorImpl : Mediator
    {
        private List<User> users;

        public MediatorImpl()
        {
            this.users = new List<User>();
        }

        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        public void BroadcastMessage(string msg, User user)
        {
            foreach(var userObj in users)
            {
                if(userObj != user)
                userObj.Receive(msg);
            }
        }
    }

    public class UserImpl : User
    {
        public UserImpl(Mediator m, string name) : base(m, name)
        { }
        public override void Receive(string msg)
        {
            Console.WriteLine(this._name + ": " + msg);
        }

        public override void Send(string msg)
        {
            _mediator.BroadcastMessage(msg, this);
        }
    }
}

/*
 *  var mediatorObj = new MediatorImpl();
    var u1 = new UserImpl(mediatorObj, "Bharath");
    var u2 = new UserImpl(mediatorObj, "Kumar");
    var u3 = new UserImpl(mediatorObj, "Ganesh");
    mediatorObj.AddUser(u1);
    mediatorObj.AddUser(u2);
    mediatorObj.AddUser(u3);
    u1.Send("Hello");

    u2.Send("Cool");

    Console.ReadLine();
 */
