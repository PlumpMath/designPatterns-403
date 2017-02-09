using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class LoadBalancer
    {
        private static LoadBalancer instance;
        private IList<string> _server = new List<string>();
        private Random _random = new Random();


        //lock synchronization object
        private static object lockObject = new object();


        protected LoadBalancer()
        {
            _server.Add("Server 1");
            _server.Add("Server 2");
            _server.Add("Server 3");
            _server.Add("Server 4");
            _server.Add("Server 5");
            _server.Add("Server 6");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if(instance == null)
            {
                lock(lockObject)
                {
                    if (instance == null)
                        instance = new LoadBalancer();
                }
            }
            return instance;
        }

        public string Server
        {
            get
            {
                int i = _random.Next(_server.Count);
                return _server[i].ToString();
            }
        }
    }
}
