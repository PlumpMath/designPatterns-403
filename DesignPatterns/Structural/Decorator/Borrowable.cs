using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Borrowable : DecoratorBase
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItemBase item)
            :base(item)
        {

        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            LibraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            LibraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach(string borrower in borrowers)
            {
                Console.WriteLine("Borrower {0}", borrower);
            }
        }
    }
}
