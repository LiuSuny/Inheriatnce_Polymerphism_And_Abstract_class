using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Inheriatnce_Polymerphism_And_Abstract_class
{
    public class HouseHoldChemicalsProducts : Products
    {
        public double Productssold;

        public HouseHoldChemicalsProducts(string _name, string _description, double _price,
            double _productSold) : base(_name, _description, _price)
        {
            Productssold = _productSold;
        }

        public virtual void PrintdataOutPut()
        {
            base.PrintdataOutPut();
            WriteLine($"HouseHoldChemical :{Productssold}");
        }
        public override void Invoice()
        {
            WriteLine($"Product sold: {Productssold} units of {Name} \ndesciprition: {Description} \nprice: {Price:c} received.");
        }

        public override void ProductOutOfStock()
        {
            if (Productssold <= 0 )
            {
                WriteLine("Prodtuct is out of stock");
            }
            else WriteLine($"Product sold: {Productssold} units of {Name} \ndesciprition: {Description} \nprice: {Price:c} current sold out of stock.");

        }

        public override void ProductSales()
        {
            if (Productssold > 1)
            {
                WriteLine($"Product sold: {Productssold} units of {Name} \ndesciprition: {Description} \nprice: {Price:c} sold.");
            }
            else
            {
                WriteLine("Low sales, try harder");
            }
        }
    }
}
