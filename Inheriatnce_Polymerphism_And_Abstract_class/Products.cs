using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;
namespace Inheriatnce_Polymerphism_And_Abstract_class
{
    public abstract class Products
    {
        protected  string Name { get; }
        protected string Description { get; }
        protected double Price { get; set; }
       

        //public string Name //call method property
        //{
        //    get { return name; }
        //    set
        //    {
        //        if (value.Any(char.IsDigit))
        //        {
        //            Name = "No Name";
        //            Console.WriteLine("Can't use numbers in name");
        //        }
        //        Name = value;
        //    }
        //}
        public Products(string _name, string _description, double _price)
        {
            Name = _name;
            Description = _description;
            Price = _price;
        }

        public virtual void PrintdataOutPut()
        {
            WriteLine($"ProductName :{Name} \nProductName :{Description} ProductPrice :{Price:c} ");
        }

        public abstract void Invoice();
        public abstract void ProductSales();
        public abstract void ProductOutOfStock();

    }
}
