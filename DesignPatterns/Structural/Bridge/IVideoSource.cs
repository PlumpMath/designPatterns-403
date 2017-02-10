using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    //Implementor
    public interface IVideoSource
    {
        string GetTVGuide();
        string PlayVideo();
    }
}
