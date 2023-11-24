//#define FIRST_INHERITANCE_FROM_HUMAN
//#define INHERIT_HUMAN_ETC
//#define INHERIT_HUMAN_ETC_REALIZATION
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //these help to avoid full Console.Writeline instead of short Writeline()

namespace Inheriatnce_Polymerphism_And_Abstract_class
{
#if INHERIT_HUMAN_ETC

    //public class Human
    //{
    //    protected int id;
    //    protected string firstName;
    //    protected string lastName;

    //    public Human(int _id, string _fName, string _lName)
    //    {
    //        id = _id;
    //        firstName = _fName;
    //        lastName = _lName;
    //    }

    //    public virtual void Print()
    //    {
    //        WriteLine($" ID: {id} \nSurName: {lastName}\nFirstName:{firstName}");
    //    }


    //}
    //public abstract class Employee : Human
    //{
    //    double _salary;
    //    public Employee(int id, string fName, string lName, double salary) : base(id, fName, lName)
    //    {
    //        _salary = salary;
    //    }
    //    public override void Print()
    //    {
    //        base.Print();
    //        WriteLine($"Salary: {_salary} $");
    //    }


    //    //public override string ToString()
    //    //{
    //    //    return $" ID: {id} \nSurName: {lastName}\nFirstName:{firstName}\nSalary: {_salary} $";
    //    //}

    //    public abstract void work();
    //    public abstract void say();


    //}


    //class Manager : Employee
    //{
    //    string _fieldActivity;
    //    public Manager(int id, string fName, string lName, double salary, string activity) : base(id, fName, lName, salary)
    //    {

    //        _fieldActivity = activity;
    //    }
    //    public override void Print()
    //    {
    //        base.Print();
    //        WriteLine($"Manager. Field of activity:{_fieldActivity}");
    //    }

    //    public override void say()
    //    {
    //        WriteLine("Manager_Say");
    //    }

    //    public override void work()
    //    {
    //        WriteLine("Manager_work");
    //    }
    //}
    //class Scientist : Employee
    //{
    //    string _scientificDirection;
    //    public Scientist(int id, string fName, string lName, double salary, string direction) : base(id, fName, lName, salary)
    //    {
    //        _scientificDirection = direction;
    //    }
    //    public override void Print()
    //    {
    //        base.Print();
    //        WriteLine($"Scientist. Scientific direction: {_scientificDirection}");
    //    }

    //    public override void say()
    //    {
    //        WriteLine("Scientist_say");
    //    }

    //    public override void work()
    //    {
    //        WriteLine("Scientist_work");
    //    }
    //}
    //class Specialist : Employee
    //{
    //    string _qualification;
    //    public Specialist(int id, string fName, string lName, double salary, string qualification) : base(id, fName, lName, salary)
    //    {
    //        _qualification = qualification;
    //    }
    //    public override void Print()
    //    {
    //        base.Print();
    //        WriteLine($"Specialist. Qualification: {_qualification}");
    //    }

    //    public override void say()
    //    {
    //        WriteLine("Specialist_say");
    //    }

    //    public override void work()
    //    {
    //        WriteLine("Specialist_work");
    //    }
    //}  
#endif
    class Program
    {
        public static readonly string delimiter = "\n____________________________\n";
        static void Main(string[] args)
        {

#if FIRST_INHERITANCE_FROM_HUMAN
            Employee employee = new Employee(30, "John", "Doe", 2563.57);
            //employee.Print();
            WriteLine(employee); 
#endif

#if INHERIT_HUMAN_ETC_REALIZATION
            // Employee manager = new Manager(3, "John", "Doe", 3500, "Food products");
            // Employee[] employees =
            // { manager,
            //new Scientist(4, "Jim", "Beam", 4253, "History"),
            //new Specialist(5, "Jack", "Smith",/*new DateTime(1996,11,5),*/ 2587.43,"Physics")
            //};
            // foreach (Employee item in employees)
            // {
            //     item.Print();
            //     item.say();
            //     item.work();
            //     //item.ShowScientist(); Error
            //     //try
            //     //{
            //     //    ((Specialist)item).
            //     //    ShowSpecialist(); // Способ №1
            //     //}
            //     //catch
            //     //{
            //     //}
            //     //Scientist scientist = item as Scientist; // Способ №2
            //     //if (scientist != null)
            //     //{
            //     //    scientist.ShowScientist();
            //     //}
            //     //if (item is Manager) // Способ №3
            //     //{
            //     //    (item as Manager).ShowManager();
            //     //}

            // }  
#endif
            //Food Products
            FoodProducts apple = new FoodProducts("Apple", "Fruit", 1.50, 10);
            FoodProducts bread = new FoodProducts("Bread", "Baked and flour", 2.00, 0);

            // Household chemicals
            HouseHoldChemicalsProducts detergent = new HouseHoldChemicalsProducts("Detergent", "mixture of surfactants", 5.50, 10);
            HouseHoldChemicalsProducts cleaner = new HouseHoldChemicalsProducts("Cleaner", "All-purpose Cleaner", 3.75, 15);

            // Operations
            apple.Invoice();
            WriteLine(delimiter);
            bread.ProductSales();
            WriteLine(delimiter);
            apple.ProductOutOfStock();
            WriteLine(delimiter);
             apple.PrintdataOutPut();
            WriteLine(delimiter);

            detergent.ProductOutOfStock();
            WriteLine(delimiter);
            cleaner.ProductSales();
            WriteLine(delimiter);
        }
    }
}








  



   