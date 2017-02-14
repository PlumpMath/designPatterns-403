using System;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Structural
{
    public class Bridge : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Decouple an abstraction from its implementation {0}so that the two can vary independently. ", Environment.NewLine);
        }

        public void Execute()
        {
            MySuperSmartTV tv = new MySuperSmartTV();

            tv.VideoSource = new IPTvService();
            tv.ShowTvGuide();
            tv.PlayTV();

            tv.VideoSource = new LocalCabelTv();
            tv.ShowTvGuide();
            tv.PlayTV();

            tv.VideoSource = new LocalDishTv();
            tv.PlayTV();
            tv.ShowTvGuide();
        }
    }
}
