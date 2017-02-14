using System;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Common.Base;

namespace DesignPatterns.Patterns.PatternExecutor.Creational
{
    public class FactoryMethod : IPatternExecutor
    {
        public string Description()
        {
            return string.Format("Define an interface for creating an object,  {0}but let subclasses decide which class to instantiate. {0}Factory Method lets a class defer instantiation to subclasses. ", Environment.NewLine);
        }

        public void Execute()
        {
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();


            foreach (var doc in documents)
            {
                Console.WriteLine("Document {0}", doc.GetType().Name);
                foreach (var page in doc.Pages)
                {
                    Console.WriteLine("Page {0}", page.GetType().Name);
                }

            }
        }

        public void Message(string message)
        {
            
        }
    }
}
