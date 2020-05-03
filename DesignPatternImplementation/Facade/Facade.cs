using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Facade
{
    public interface IBuild
    {
        void Construct();
    }

    public class Building : IBuild
    {
        public void Construct()
        {
            Console.WriteLine("Building Constructed");
        }
    }

    public class Table : IBuild
    {
        public void Construct()
        {
            Console.WriteLine("Table Constructed");
        }
    }

    public class FacadeMaker
    {
        private IBuild _building;
        private IBuild _table;

        public FacadeMaker()
        {
            _building = new Building();
            _table = new Table();
        }

        public void BuildBuilding()
        {
            _building.Construct();
        }

        public void BuildTable()
        {
            _table.Construct();
        }
    }
}

/*
    var facade = new FacadeMaker();
    facade.BuildBuilding();
    facade.BuildTable();

    Console.ReadLine();
*/
