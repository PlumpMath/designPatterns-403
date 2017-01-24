using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Book : LibraryItemBase
    {
        private string _author;
        private string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Book");
            Console.WriteLine("Author {0}", _author);
            Console.WriteLine("Title {0}", _title);
            Console.WriteLine("NumCopies {0}", NumCopies);
        }
    }
}
