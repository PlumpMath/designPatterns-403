using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    //refined abstarction
    public class MySuperSmartTV
    {
        private IVideoSource _currentSource = null;

        public IVideoSource VideoSource
        {
            get
            {
                return _currentSource;
            }
            set
            {
                _currentSource = value;
            }
        }

        public void ShowTvGuide()
        {
            if(_currentSource != null)
            {
                Console.WriteLine(_currentSource.GetTVGuide());
            }
            else
            {
                Console.WriteLine("Please select a Video Source to get TV guide from");
            }
        }

        public void PlayTV()
        {
            if(_currentSource != null)
            {
                Console.WriteLine(_currentSource.PlayVideo());
            }
            else
            {
                Console.WriteLine("Please select a Video Source to play");
            }
        }
    }
}
