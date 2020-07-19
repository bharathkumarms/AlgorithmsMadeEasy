using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternImplementation.ActiveObjectDesignPattern
{
    public class ActiveObject
    {
        public class MyTask
        {
            public int priority;
            public string name;
            public MyTask(string name, int priority)
            {
                this.name = name;
                this.priority = priority;
            }
        }

        ConcurrentQueue<MyTask> dispatchQueue = new ConcurrentQueue<MyTask>();

        public void Do(string name, int priority)
        {
            dispatchQueue.Enqueue(new MyTask(name, priority));

            new Thread(() =>
            {
                MyTask task;
                var isSuccess = dispatchQueue.TryDequeue(out task);
                Console.WriteLine("Executing: " + task.name);
            }).Start();
        }
    }
}

/*
    var activeObject = new ActiveObject();

    Thread t1 = new Thread(() => activeObject.Do("1", 1));
    Thread t2 = new Thread(() => activeObject.Do("2", 2));
    Thread t3 = new Thread(() => activeObject.Do("3", 3));

    t1.Start();
    t2.Start();
    t3.Start();

    Console.ReadLine();
*/
