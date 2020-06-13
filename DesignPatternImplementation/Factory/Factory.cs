using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Factory
{
    public interface ILevel
    {
        void Play();
    }

    public class Mountain : ILevel
    {
        public void Play()
        {
            Console.WriteLine("Construct and play in mountain");
        }
    }

    public class Water : ILevel
    {
        public void Play()
        {
            Console.WriteLine("Construct and play in water");
        }
    }

    public class Terrain : ILevel
    {
        public void Play()
        {
            Console.WriteLine("Construct and play in terrain");
        }
    }

    public class GameFactory
    {
        public ILevel GetLevel(string level)
        {
            if(level == "mountain")
            {
                return new Mountain();
            }else if(level == "water")
            {
                return new Water();
            }

            return new Terrain();
        }
    }
}

/*
    var factory = new GameFactory();

    ILevel level1 = factory.GetLevel("terrain");
    level1.Play();

    ILevel level2 = factory.GetLevel("water");
    level2.Play();

    ILevel level3 = factory.GetLevel("mountain");
    level3.Play();

    Console.ReadLine();
*/
