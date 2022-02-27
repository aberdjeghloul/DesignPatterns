using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public sealed class Singleton
    {

        private static int counter = 0;
        private static Singleton _instance = null;
                
        //Public property 
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        //Private constructor
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value " + counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
           
    }
}
