using System;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Structural
{
    public class Decorator : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Attach additional responsibilities to an object dynamically.{0}Decorators provide a flexible alternative to {0}subclassing for extending functionality.", Environment.NewLine);
        }

        public string DescriptionPL()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            Message("Tworzymy obiekt Book który dziedziczy po abstrakcji LibraryItemBase");     
            LibraryItemBase book = new Book("Wiśniewski", "Samotność w sieci", 2);
            book.Display();

            Message("Tworzymy obiekt video który dziedziczy również po abstrakcji LibraryItemBase");
            LibraryItemBase video = new Video("Star wars", "George Lucas", 120, 3);
            video.Display();

            Message(string.Format("Tworzymy obiekt który bedziemy dekorować{0}Dziedziczy on po abstrakcji dekoratora, który z kolei dziedziczy po LibraryItemBase{0}W dekratorze jest referencja do obiektu LibraryItemBase", Environment.NewLine));         
            Borrowable borrowable = new Borrowable(book);
            borrowable.BorrowItem("Customer1");
            borrowable.BorrowItem("Customer2");

            borrowable.Display();

            Message(string.Format("SCHEMAT: {0}LibraryItemBase(ComponentBase) <--- Video,Book(Concrete component){0}LibraryItemBase <--- Decorator(Decorator){0}Decorator <---Obiekt dekorowany(Concrete decorator)", Environment.NewLine));
            Message(string.Format("UWAGI{0}Obiekt dekorujący musi posiadać konstruktor z parametrem LibraryItemBase który jest przepisany z Decoratora", Environment.NewLine));

        }

        public void Message(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine("[Enter]");
            Console.ReadLine();
        }
    }
}
