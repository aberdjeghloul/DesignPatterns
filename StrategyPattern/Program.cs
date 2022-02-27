using System;

namespace StrategyPattern
{
    /// <summary>
    /// Strategy Design Pattern. 
    /// According to Gang of Four Definitions, define a family of algorithms, encapsulate each one, and make them interchangeable. 
    /// Strategy lets the algorithm vary independently from clients that use it.
    /// The Strategy Design Pattern is used when we have multiple algorithms(solutions) for a specific task and the client decides the actual implementation to be used at runtime.
    /// In simple words, we can say that the Strategy Design Pattern(also called policy pattern) attempts to solve the issue where you need to provide multiple solutions 
    /// for the same problem so that one can be selected at runtime.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            CompressionContext ctx = new CompressionContext(new ZipCompress());
            ctx.CreateArchive("StrategyPatternFolder");

            ctx.SetStrategy(new RarCompression());
            ctx.CreateArchive("StrategyPatternFolder");

            Console.ReadKey();
        }
    }
}
