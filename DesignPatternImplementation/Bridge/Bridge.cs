using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Bridge
{
    public interface IDownloaderAbstraction
    {
        public object Download(string url);
        public bool Save(object obj);
    }

    public interface IDownloaderImplementation
    {
        public object Download(string url);
        public bool Save(object obj);
    }

    public class DownloaderAbstractionImpl : IDownloaderAbstraction
    {
        private readonly IDownloaderImplementation _provider;

        public DownloaderAbstractionImpl(IDownloaderImplementation provider)
        {
            this._provider = provider;
        }

        public object Download(string url)
        {
            return _provider.Download(url);
        }

        public bool Save(object obj)
        {
            return _provider.Save(obj);
        }
    }

    public class LinuxDownloaderImpl : IDownloaderImplementation
    {
        public object Download(string url)
        {
            return new object();
        }

        public bool Save(object obj)
        {
            Console.WriteLine("Downloaded file in Linux!");
            return true;
        }
    }

    public class WindowsDownloaderImpl : IDownloaderImplementation
    {
        public object Download(string url)
        {
            return new object();
        }

        public bool Save(object obj)
        {
            Console.WriteLine("Downloaded file in Windows!");
            return true;
        }
    }
}
/*
    string os = "windows";

    IDownloaderAbstraction handle = null;

    switch (os)
    {
        case "windows":
            handle = new DownloaderAbstractionImpl(new WindowsDownloaderImpl());
            break;
        case "linux":
            handle = new DownloaderAbstractionImpl(new LinuxDownloaderImpl());
            break;
    }

    object obj = handle.Download("some url");
    handle.Save(obj);

    Console.ReadLine();
*/
