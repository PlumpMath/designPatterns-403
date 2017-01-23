using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.Builder;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string choose;
            int number;
            const string END = "E";
                      
            do
            {
                Console.WriteLine("Select design pattern to show");
                Console.WriteLine("[1]. Builder pattern");
                Console.WriteLine("[E]. Exit");

                choose = Console.ReadLine();

                if (Int32.TryParse(choose, out number))
                {
                    ExecuteBuilder(CreatePatternExecutor(number));
                }
                else
                    Console.WriteLine("Incorect format");
            }
            while (choose.ToUpper() != END);
                
        }

        static void ExecuteBuilder(IPatternExecutor pattern )
        {
            if (pattern != null)
                pattern.Execute();
        }

        static IPatternExecutor CreatePatternExecutor(int index)
        {
            IPatternExecutor _pattern = null;
            switch (index)
            {
                case 1:
                    _pattern = new BuilderExecutor();
                    break;
                default:
                    break;
            }
            return _pattern;
        }
    }
}
