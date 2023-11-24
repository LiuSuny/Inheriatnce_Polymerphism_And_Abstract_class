using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheriatnce_Polymerphism_And_Abstract_class
{
    public class PaperTowels :HouseHoldChemicalsProducts
    {
        string ProductType { get; set; }
        public PaperTowels(string _name, string _description, double _price,
           double _productSold, string _productType) : base(_name, _description, _price, _productSold)
        {
            Productssold = _productSold;
        }

        public virtual void PrintdataOutPut()
        {
            base.PrintdataOutPut();
            Console.WriteLine($"Type of Bleach:{ProductType}");
        }
    }
}
