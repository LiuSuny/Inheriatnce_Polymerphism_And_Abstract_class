using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Inheriatnce_Polymerphism_And_Abstract_class
{
    public class FoodProducts : Products
    {
         public double Appearance { get; set; }
        
        //public string Appearance
        //{ 
        //    get {return Appearance; }
        //set
        //    {
        //        if (value.Length< 0)
        //        {
        //            Appearance = "0";
        //            WriteLine("Food products is out of stock");
        //        }
        //        else
        //        {
        //            Appearance = value;
        //        }
        //    }
        //}
        public FoodProducts(string _name, string _description, double _price,
           double _appearance) : base(_name, _description, _price)
        {
            Appearance = _appearance;
          
        }
        public virtual void PrintdataOutPut()
        {
            base.PrintdataOutPut();
            WriteLine( $"FoodProducts Appearance :{Appearance}");
        }
        public override void Invoice()
        {
            WriteLine($"Appearance of:  {Appearance} units {Name} \ndesciprition: {Description} \nprice {Price:c} received.");
        }

        public override void ProductOutOfStock()
        {
            if (Appearance <= 0 )
            {
                Appearance = 0;
                WriteLine("Prodtuct is out of stock");
                
            }
            else WriteLine($"Appearance of {Appearance} units of {Name} \ndesciprition: {Description} \nprice: {Price:c} currently taking out of stock.");


        }

        public override void ProductSales()
        {
            if (Appearance > 1)
            {
                WriteLine($"{Appearance} units of {Name} \ndesciprition: {Description} \nprice: {Price:c} sold.");
            }
            else WriteLine("Try hard, low sales");
            
        }
    }
}
