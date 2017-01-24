using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class DecoratorBase : LibraryItemBase
    {
        private LibraryItemBase _libraryItem;

        protected LibraryItemBase LibraryItem
        {
            get { return _libraryItem; }
            set { _libraryItem = value; }
        }

        public DecoratorBase(LibraryItemBase item)
        {
            LibraryItem = item;
        }

        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}
