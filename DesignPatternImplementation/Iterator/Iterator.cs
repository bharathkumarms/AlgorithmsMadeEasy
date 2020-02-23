using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Iterator
{
    public interface Iterator
    {
        public bool HasNext();
        public Object Next();
    }

    public interface Container
    {
        public Iterator GetIterator();
    }

    public class NameRepository : Container
    {
        private static string[] names = { "bharath", "kumar", "ganesh" };

        public Iterator GetIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : Iterator
        {
            int index;
            public bool HasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object Next()
            {
                if (HasNext())
                {
                    return names[index++];
                }

                return null;
            }
        }
    }
}

/*
    var repo = new NameRepository();
    var i = repo.GetIterator();
    while (i.HasNext())
    {
        Console.WriteLine(i.Next());
    }
 */
