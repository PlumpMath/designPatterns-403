using DesignPatterns.Helpers;
using DesignPatterns.PatternsType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns
{
    class Program
    {
        static IDictionary<int, string> Menu { get; set; }
        const string ASSEMBLY_NAME = "DesignPatterns.PatternsType";

        static void Main(string[] args)
        {
            #region const
            const string END = "E";
            const string MENU_CACHE_NAME = "MainMenu";
            #endregion

            string choose;
            int number;       
            MenuBuilder menu = new MenuBuilder();

            do
            {
                Console.WriteLine("Select design pattern to show");

                var cache = LocalCache.Instance.Get<IDictionary<int, string>>(MENU_CACHE_NAME);

                if (cache != null)
                    Menu = cache;
                else
                {
                    Menu = menu.BuildMenu<PatternsTypeBase>();
                    LocalCache.Instance.Add<IDictionary<int, string>>(Menu, MENU_CACHE_NAME);
                }
              
                foreach (var item in Menu)
                    Console.WriteLine("[{0}]. {1}.", item.Key, item.Value);

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
            if(Menu.Count >= number)
            {
                string className = Menu[number];
                PatternSelector patternSelector = new PatternSelector(className, ASSEMBLY_NAME);
                patternSelector.SelectPatterns();
            }
        }
    }
}
