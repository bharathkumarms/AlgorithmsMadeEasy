using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Composite
{
    public interface IEmployee
    {
        public void DisplayEmployee();
    }

    class Developer : IEmployee
    {
        private string _name;

        public Developer(string name)
        {
            _name = name;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine(_name + " is a Developer");
        }
    }

    class Designer : IEmployee
    {
        private string _name;

        public Designer(string name)
        {
            _name = name;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine(_name + " is a Designer");
        }
    }

    class Directory : IEmployee
    {
        private List<IEmployee> directory = new List<IEmployee>();
        public void DisplayEmployee()
        {
            foreach (var d in directory)
            {
                d.DisplayEmployee();
            }
        }

        public void Add(IEmployee e)
        {
            directory.Add(e);     
        }

        public void Remove(IEmployee e)
        {
            directory.Remove(e);
        }
    }
}
/*
    var developer = new Developer("Bharath");
    var designer = new Designer("Sudharsan");

    var directory = new Directory();
    directory.Add(developer);
    directory.Add(designer);

    directory.DisplayEmployee();
            
    Console.ReadLine();
*/
