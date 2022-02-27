using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.RealWorld
{
    /// <summary>
    /// The Singleton class
    /// </summary>
    public sealed class LoadBalancer
    {
        private static LoadBalancer _instance = null;

        /// <summary>
        /// lock synchronization object
        /// </summary>
        private static object locker = new object();

        List<string> servers = new List<string>();
        Random random = new Random();

        /// <summary>
        /// private constructor
        /// </summary>
        private LoadBalancer()
        {            
            servers.Add("ServerI");
            servers.Add("ServerII");
            servers.Add("ServerIII");
            servers.Add("ServerIV");
            servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            //Support multithreading applications through Double checked locking pattern which
            //(once the instance exists) avoids locking each time the method is invoked
            if (_instance == null)
            {                
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }
            return _instance;
        }

        //Simple, but effective random load balancer
        public string GetServer()
        {
            int r = random.Next(servers.Count);
            return servers[r].ToString();
        }
    }
}
