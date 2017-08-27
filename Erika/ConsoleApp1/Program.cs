using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erika
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Warehouse> warehouseList = new List<Warehouse>();

            Warehouse tonimbuk = new Warehouse();
            Warehouse georgeSt = new Warehouse();
            Warehouse lochSport = new Warehouse();

            warehouseList.Add(tonimbuk);
            warehouseList.Add(georgeSt);
            warehouseList.Add(lochSport);

            Console.WriteLine("Welcome to Erika");
            Console.WriteLine("Please make your selection below");
            Console.WriteLine("[a] - Inventory Report");
            Console.WriteLine("[b] - Add Bottle");
            Console.WriteLine("[c] - Select Bottle");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "a":
                    Console.WriteLine("You selected Inventory Report");
                    break;
                case "b":
                    Console.WriteLine("You selected Add Bottle");
                    break;
                case "c":
                    Console.WriteLine("You selected Drink Bottle");
                    break;
                default:
                    Console.WriteLine("You didn't make a valid selection");
                    break;
            }
        }
    }
}
// This is a comment.
// Another comment.