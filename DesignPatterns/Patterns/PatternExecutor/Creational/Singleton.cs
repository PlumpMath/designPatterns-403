﻿using System;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Creational
{
    public class Singleton : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Ensure a class has only one instance and provide a global point of access to it. ");
        }

        public string DescriptionPL()
        {
            return string.Empty;
        }

        public void Execute()
        {
            LoadBalancer l1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer l2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer l3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer l4 = LoadBalancer.GetLoadBalancer();

            if (l1 == l2 && l3 == l4)
                Console.WriteLine("Same instance");

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Dispatch server {0}", server);
            }
        }

        public void Message(string message)
        {
            
        }
    }
}
