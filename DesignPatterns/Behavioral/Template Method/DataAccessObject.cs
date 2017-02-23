using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template_Method
{
    public abstract class DataAccessObject
    {
        private string _conectionString;

        public virtual void Connect()
        {
            _conectionString = "abstractConnectionString";
            Console.WriteLine(_conectionString);
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            _conectionString = string.Empty;
            Console.WriteLine("Disconnection");
        }

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
