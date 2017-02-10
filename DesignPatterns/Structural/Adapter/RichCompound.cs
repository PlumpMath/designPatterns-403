using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    //Adapter
    public class RichCompound : Compound
    {
        private ChemicalDataBank _bank;

        public RichCompound(string name)
            :base(name)
        {
        }

        public override void Display()
        {
            _bank = new ChemicalDataBank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularFormula = _bank.GetMolecularStructure(_chemical);
            _molecularWeight = _bank.GetMolecularWeight(_chemical);

            base.Display();
            Console.WriteLine("Formula: {0}", _molecularFormula);
            Console.WriteLine("Weight: {0}", _molecularWeight);
            Console.WriteLine("Melting: {0}", _meltingPoint);
            Console.WriteLine("Boiling: {0}", _boilingPoint);
        }
    }
}
