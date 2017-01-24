using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class Video : LibraryItemBase
    {
        private string _title;
        private string _director;
        private int _playTime;


        public Video(string title, string director, int playTime, int numCopies)
        {
            _title = title;
            _director = director;
            _playTime = playTime;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("Book");
            Console.WriteLine("Director {0}", _director);
            Console.WriteLine("Title {0}", _title);
            Console.WriteLine("NumCopies {0}", NumCopies);
        }
    }
}
