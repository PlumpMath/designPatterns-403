using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                Console.WriteLine("[1]. Creational");
                Console.WriteLine("[2]. Structural");
                Console.WriteLine("[3]. Behavioral");
                Console.WriteLine("[E]. Exit");

                choose = Console.ReadLine();

                if (Int32.TryParse(choose, out number))
                {
                    SelectPattern(number);
                }
                else
                    Console.WriteLine("Incorect format");
            }
            while (choose.ToUpper() != END);
                
        }
              
        static void SelectPattern(int number)
        {
            PatternSelector patternSelector = new PatternSelector(number);
            patternSelector.SelectPatterns();
        }
    }
}
