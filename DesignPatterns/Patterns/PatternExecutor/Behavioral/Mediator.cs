using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Behavioral
{
    public class Mediator : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently");
        }

        public string DescriptionPL()
        {
            return string.Empty;
        }

        public void Execute()
        {
            IColleague<string> colleague1 = new ConcreteColleague<string>("1");
            IColleague<string> colleague2 = new ConcreteColleague<string>("2");
            IColleague<string> colleague3 = new ConcreteColleague<string>("3");
            IColleague<string> colleague4 = new ConcreteColleague<string>("4");

            IMediator<string> mediator1 = new ConreteMediator<string>();
            mediator1.Register(colleague1);
            mediator1.Register(colleague2);
            mediator1.Register(colleague3);
            mediator1.Register(colleague4);

            colleague1.SendMessage(mediator1, "message X from 1");

            IMediator<string> mediator2 = new ConreteMediator<string>();
            mediator2.Register(colleague1);
            mediator2.Register(colleague2);
            mediator2.Register(colleague3);
            mediator2.Register(colleague4);

            colleague3.SendMessage(mediator2, "send Y from 3");
            colleague4.SendMessage(mediator2, "send massage from 4");
        }
    }
}
