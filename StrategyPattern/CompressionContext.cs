using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Context (Composition).This context class contains a property that is used to hold the reference of a Strategy object. 
    /// This property will be set at run-time by the client according to the algorithm that is required.
    /// Context is configured with a ConcreteStrategy object
    /// Context maintains a reference to a Strategy object
    /// Context may define an interface that lefts Strategy access its data
    /// </summary>
    public class CompressionContext
    {
        private ICompression _compression;

        public CompressionContext(ICompression compression)
        {
            _compression = compression;
        }

        public void SetStrategy(ICompression compression)
        {
            _compression = compression;
        }

        public void CreateArchive(string compressedArchiveFileName)
        {
            _compression.CompressFolder(compressedArchiveFileName);
        }
    }
}
