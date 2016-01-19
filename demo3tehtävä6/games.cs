using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Laite
    {
        // fied member

        //properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Bits { get; set; }
        public int Price { get; set; }
        public bool backwardsCompatibility { get; set; }

        // constructor
        public Laite()
        {
            backwardsCompatibility = true;
        }


        // parametric constructor
        public Laite(string model)
        {
            Model = model;
        }

        // method displays car data
        public void PrintData()
        {
            Console.WriteLine("Console data: ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- Color : " + Color);
            Console.WriteLine("- Bits : " + Bits);
            Console.WriteLine("- Price : " + Price);
            Console.WriteLine("- backwards Compatibility : " + backwardsCompatibility);
      


        }
        public void PriceDrop(int NewPrice)
        {
            Price -= NewPrice;
        }

        public override string ToString()
        {
            return "Model :" + Model + "Color : " + Color + "IsOn : " + Bits + "Bits : "+ Price + "backwards Compatibility " + backwardsCompatibility;
        }
     
    }

}