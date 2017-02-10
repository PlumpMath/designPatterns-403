using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PatternsType
{
    public sealed class PatternTypeEnum
    {
        private readonly string _name;

        public static readonly PatternTypeEnum Behavioral = new PatternTypeEnum("Behavioral");
        public static readonly PatternTypeEnum Creational = new PatternTypeEnum("Creational");
        public static readonly PatternTypeEnum Structural = new PatternTypeEnum("Structural");
        public static readonly PatternTypeEnum Others = new PatternTypeEnum("Others");

        private PatternTypeEnum(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
