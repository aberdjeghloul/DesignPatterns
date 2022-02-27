using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Abstract Strategy. The Strategy declares an interface that is common to all supported algorithms. 
    /// The Context object uses this interface to call the algorithm defined by a ConcreteStrategy
    /// </summary>
    public interface ICompression
    {
        void CompressFolder(string compressedArchiveFileName);
    }
}
