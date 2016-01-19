using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{

    class Program
    {
        static void Main(string[] args)
        {
         
            Laite ps3 = new Laite();
            ps3.Model = "PS3";
            ps3.Color = "Piano Black";
            ps3.Bits = 256;
            ps3.backwardsCompatibility = false;
            ps3.Price = 300;
            ps3.PrintData();
            ps3.PriceDrop(50);
            Console.WriteLine("- Price after drop : ");
            ps3.PrintData();
       
            Console.ReadLine();



            Laite ps2 = new Laite("PS2");

      
            ps2.Price = 200;
            ps2.Color = "black";
            ps2.Bits = 128;
            ps2.backwardsCompatibility = true;
            ps2.PrintData();
            ps2.PriceDrop(50);
            Console.WriteLine("- Price after drop : ");
            ps2.PrintData();
        
            Console.ReadLine();


            Laite ps1 = new Laite("PS1");


            ps1.Price = 200;
            ps1.Color = "Grey";
            ps1.Bits = 64;
            ps1.backwardsCompatibility = false;
            ps1.PrintData();
            ps1.PriceDrop(50);
            Console.WriteLine("- Price after drop : ");
            ps1.PrintData();
      
            Console.ReadLine();


        }
    }
}








