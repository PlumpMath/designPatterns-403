using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    //Concrete implementor
    public class IPTvService : IVideoSource
    {
        const string SOURCE_NAME = "IP TV";

        public string GetTVGuide()
        {
            return string.Format("Getting TV guide from - {0}", SOURCE_NAME);
        }

        public string PlayVideo()
        {
            return string.Format("Playing - {0}", SOURCE_NAME);
        }
    }
}
