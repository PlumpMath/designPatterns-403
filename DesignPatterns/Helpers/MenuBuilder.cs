using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Helpers
{
    public class MenuBuilder
    {
        private IDictionary<int, string> idsAndNames = new Dictionary<int, string>();
        private const string CUT_THIS_STRING = "Executor";

        /// <summary>
        /// Builds menu of classes based on the inherited type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public IDictionary<int, string> BuildMenu<T>(PatternsType.PatternTypeEnum patternType)
        {            
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
                        idsAndNames.Add(counter, c.Name.Replace(CUT_THIS_STRING, string.Empty));
                        counter++;
                    }                  
                }
            }

            return idsAndNames;
        }
    }
}
