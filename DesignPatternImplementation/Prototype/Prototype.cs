using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Prototype
{
    public class Language : ICloneable
    {
        private List<string> _languages = new List<string>();

        public void Load()
        {
            //This is a database operation
            _languages.Add("C#");
            _languages.Add("Java");
            _languages.Add("Groovy");
        }

        public List<string> Get()
        {
            return _languages;
        }

        public void Print()
        {
            foreach(var l in _languages)
            {
                Console.Write(l + " ");
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
/*
    var language = new Language();
    language.Load();

    var cloned = (Language)language.Clone();
    var cloneList = cloned.Get();
    cloneList.Add("Python");

    cloned.Print();
*/
