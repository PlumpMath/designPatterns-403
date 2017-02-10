using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    //Adaptee
    public class ChemicalDataBank
    {

        public float GetCriticalPoint(string compound, string point)
        {
            return 0f;
        }

        public string GetMolecularStructure(string compound)
        {
            return "";
        }

        public double GetMolecularWeight(string compound)
        {
            return 0.0;
        }
    }
}
