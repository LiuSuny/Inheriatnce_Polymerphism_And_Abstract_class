using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheriatnce_Polymerphism_And_Abstract_class
{
    public class MeatPie:FoodProducts
    {
        string Category { get; set; }
        public MeatPie(string _name, string _description, double _price,
           double _appearance, string _category) : base(_name, _description, _price, _appearance)
        {
            Category = _category;
        }

        public virtual void PrintdataOutPut()
        {
            base.PrintdataOutPut();
            Console.WriteLine($"Fruit category :{Category}");
        }
    }
}
