using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    //Concrete creator
    public class Report : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new InstrudutionPage());
            Pages.Add(new SummaryPage());
        }
    }
}
