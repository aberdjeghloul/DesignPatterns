using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// Concrete Strategy. Implements the algorithm using the Strategy interface.
    /// Each concrete strategy by which we will compress a file item must be implementing the method CompressFolder of ICompression interface. 
    /// Let’s create two concrete strategy classes as per our business requirement.
    /// </summary>
    public class ZipCompress : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Zip approach: '" + compressedArchiveFileName + ".zip' file is created");
        }
    }
}
