using System;
using System.Collections.Generic;

namespace SingletonPattern.RealWorld
{
    class Program
    {
        /// <summary>        
        /// This real-world code demonstrates the Singleton Pattern as a LoadBalancing objet.
        /// Only a single instance (singleton) of the class can be created 
        /// because servers may dynamically come on or off line and every requests must go throught the one object that has knowledge 
        /// about the state of the web farm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random random = new Random();
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();            

            //Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }            

            //Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            
            for (int i = 0; i < 15; i++)
            {                
                if (i > 2)
                {
                    int r = random.Next(i);
                    if (r % 2 == random.Next(2))
                    {
                        balancer = LoadBalancer.GetLoadBalancer();                        
                    }
                }
                string server = balancer.GetServer();
                Console.WriteLine("Dispatch Request to: " + server);
            }

            Console.ReadKey();
        }
    }
}
