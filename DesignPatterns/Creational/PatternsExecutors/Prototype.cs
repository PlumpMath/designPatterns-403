using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.Prototype;

namespace DesignPatterns.Creational.PatternsExecutors
{
    public class Prototype : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("PROTOTYPE PATTERN{0}Specify the kind of objects to create using a prototypical {0}instance, and create new objects by copying this prototype.{0}", Environment.NewLine);
        }

        public void Execute()
        {
            ColorManager colorManager = new ColorManager();

            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            colorManager["angry"] = new Color(255, 54, 0);

            Color c1 = colorManager["red"].Clone() as Color;

            Console.WriteLine();

        }

        public void Message(string message)
        {
            throw new NotImplementedException();
        }
    }
}
