using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Strategy
{
    public interface ICompressionStrategy
    {
        public void CompressFile();
    }

    public class ZipCompression : ICompressionStrategy
    {
        public void CompressFile()
        {
            Console.WriteLine("Compression using zip");
        }
    }

    public class RarCompression : ICompressionStrategy
    {
        public void CompressFile()
        {
            Console.WriteLine("Compression using rar");
        }
    }

    public class CompressionContext
    {
        private ICompressionStrategy _compressionStrategy;

        public void SetCompressionStrategy(ICompressionStrategy strategy)
        {
            this._compressionStrategy = strategy;
        }

        public void Archive()
        {
            this._compressionStrategy.CompressFile();
        }
    }
}

/*
    var context = new CompressionContext();

    context.SetCompressionStrategy(new ZipCompression());
    context.Archive();

    context.SetCompressionStrategy(new RarCompression());
    context.Archive();

    Console.ReadLine();
 */
