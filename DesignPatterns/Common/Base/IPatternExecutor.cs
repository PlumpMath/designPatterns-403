using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Common.Base
{
    public interface IPatternExecutor
    {
        void Execute();
        string Description();
        string DescriptionPL();
    }
}
