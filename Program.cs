using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            Console.WriteLine("House Blend Coffee");
            Console.WriteLine("------------------");

            // Let us create a Simple House Blend
            HouseBlend hBlend = new HouseBlend();
            PrintProductDetails(hBlend);

            // Lets add milk to the House Blend
            MilkDecorator milkCoffee = new MilkDecorator(hBlend);
            PrintProductDetails(milkCoffee);

            // Let now add Mocha in it
            MochaDecorator mochaCoffee = new MochaDecorator(milkCoffee);
            PrintProductDetails(mochaCoffee);

            // Lets now add Whip Cream to it
            WhipDecorator whipCoffee = new WhipDecorator(mochaCoffee);
            PrintProductDetails(whipCoffee);

            // Finally add a Recycle Cup to serve the coffee
            RecycleCupDecorator recycleCup = new RecycleCupDecorator(whipCoffee);
            PrintProductDetails(recycleCup);

            Console.WriteLine("");
            Console.WriteLine("Decaf Coffee");
            Console.WriteLine("------------");

            // Lets now create a simple Decaf Coffee
            DecafCoffee decaf = new DecafCoffee();
            PrintProductDetails(decaf);

            // Lets add milk and mocha and extra mocha to the Decaf Coffee
            MilkDecorator milkDecaf = new MilkDecorator(decaf);
            MochaDecorator mochaDecaf = new MochaDecorator(milkDecaf);
            MochaDecorator mochaDecaf2 = new MochaDecorator(mochaDecaf);
            PrintProductDetails(mochaDecaf2);
        }
        private static void PrintProductDetails(CoffeeComponent product)
        {
            Console.WriteLine(); 
            Console.WriteLine("Item: {0}, Total Price: ${1}", product.GetName(), product.GetPrice());
            Console.ReadKey(true);
        }
    }
}
