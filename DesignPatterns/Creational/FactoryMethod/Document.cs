using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    //Creator
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePage();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        public abstract void CreatePage();
    }
}
