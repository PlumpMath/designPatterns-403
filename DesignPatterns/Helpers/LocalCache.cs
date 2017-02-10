using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace DesignPatterns.Helpers
{
    public class LocalCache
    {
        private static LocalCache _instance;

        private static object lockObject = new object();

        private static ObjectCache cache;

        protected LocalCache()
        {
            cache = MemoryCache.Default;
        }

        public static LocalCache Instance
        {
            get
            {
                lock(lockObject)
                {
                    if (_instance == null)
                        _instance = new LocalCache();
                    return _instance;
                }
            }
        }

        public void Add<T>(T item, string name)
        {
            cache[name] = item;
        }

        public T Get<T>(string name)
        {
            return (T)cache[name];
        }
    }
}
