using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Visitor
{
    public interface Router
    {
        public void SendData(char[] data);
        public void ReceiveData(char[] data);

        public void Accept(Visitable v);
    }

    public interface Visitable
    {
        public void Visit(DLinkRouter router);
        public void Visit(TPLinkRouter router);
    }

    public class DLinkRouter : Router
    {
        public void ReceiveData(char[] data)
        { }

        public void SendData(char[] data)
        { }

        public void Accept(Visitable v)
        {
            v.Visit(this);
        }
    }

    public class TPLinkRouter : Router
    {
        public void ReceiveData(char[] data)
        { }

        public void SendData(char[] data)
        { }

        public void Accept(Visitable v)
        {
            v.Visit(this);
        }
    }

    public class LinuxConfigurator : Visitable
    {
        public void Visit(DLinkRouter router)
        {
            Console.WriteLine("DLinkRouter Linux configuration done.");
        }

        public void Visit(TPLinkRouter router)
        {
            Console.WriteLine("TPLinkRouter Linux configuration done.");
        }
    }

    public class WindowsConfigurator : Visitable
    {
        public void Visit(DLinkRouter router)
        {
            Console.WriteLine("DLinkRouter Windows configuration done.");
        }

        public void Visit(TPLinkRouter router)
        {
            Console.WriteLine("TPLinkRouter Windows configuration done.");
        }
    }
}

/*
    var linuxConfigurator = new LinuxConfigurator();
    var dLinkRouter = new DLinkRouter();
    var tpLinkRouter = new TPLinkRouter();
    linuxConfigurator.Visit(dLinkRouter);
    linuxConfigurator.Visit(tpLinkRouter);

    Console.WriteLine();

    var windowsConfigurator = new WindowsConfigurator();
    windowsConfigurator.Visit(dLinkRouter);
    windowsConfigurator.Visit(tpLinkRouter);

    Console.ReadLine();
*/
