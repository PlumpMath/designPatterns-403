using DesignPatterns.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Common.Helpers
{
    public class MenuBuilder
    {
               
        public IDictionary<int, string> BuildMenu<T>()
        {
            IDictionary<int, string> idsAndNames = new Dictionary<int, string>();
            Type type = typeof(T);
            var listOfClasses = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => type.IsAssignableFrom(p));
            int counter = 1;

            foreach (var c in listOfClasses)
            {
                if (c.IsClass && !c.IsAbstract)
                {
                        idsAndNames.Add(counter, c.Name);
                        counter++;
                }
            }

            return idsAndNames;
        }
        /// <summary>
        /// Builds menu of classes based on the inherited type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public IDictionary<int, string> BuildMenu<T>(PatternTypeEnum patternType)
        {
            IDictionary<int, string> idsAndNames = new Dictionary<int, string>();
            Type type = typeof(T);
            var listOfClasses = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => type.IsAssignableFrom(p));
            int counter = 1;

            foreach(var c in listOfClasses)
            {
                if(c.IsClass)
                {
                    var typeName = c.Namespace.Split('.');
                    if (typeName[typeName.Length - 2] == patternType.ToString())
                    {
                        idsAndNames.Add(counter, c.Name);
                        counter++;
                    }                  
                }
            }

            return idsAndNames;
        }
    }
}
