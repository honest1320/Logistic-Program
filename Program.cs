/******************************************************************************************                                                                                      
                        NAME....: HONEST ALBERT TEMU                                                                              
                                                                                          
**********************************************************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticProgram
{
    class CustomerInfo
    {
        public string customerName, customerAdres, customerMail, customerWeb, customerDate;
        public long customerTel, customerFax, customerTax;
    }

    class Products 
    {
        public string productName;
        public long productDistance;
        public double productFactor;
    }

    class Solid : Products 
    {
        public float solidTonnage, solidVolume;
    }

    class Liquid : Products 
    {
        public float liquidTonnage, specificWeight;
    }

    class Gas : Products
    {
        public long gasType;
        public float gasVolume;
    }

    class Valuables : Products
    {
        public long valuablesQuantity;
        public float valuablesVolume, valuablesTonnage, valuablesQuantityWeight;
    }

    class Program
    {
        public static int urunSecim;

        static void Main(string[] args)
        {
            CustomerInfo customer = new CustomerInfo(); 

            Console.Write("Customer Name...:"); customer.customerName = Console.ReadLine();
            Console.Write("Address.........:"); customer.customerAdres = Console.ReadLine();
            Console.Write("Telephone.......:"); customer.customerTel = Convert.ToInt64(Console.ReadLine());
            Console.Write("Fax.............:"); customer.customerFax = Convert.ToInt64(Console.ReadLine());
            Console.Write("Mail............:"); customer.customerMail = Console.ReadLine();
            Console.Write("Web Address.....:"); customer.customerWeb = Console.ReadLine();
            Console.Write("Tax No. ........:"); customer.customerTax = Convert.ToInt64(Console.ReadLine());
            Console.Write("Order Date......:"); customer.customerDate = Console.ReadLine();

            Products mesafe = new Products();

            Console.Write("\n\nDistance To Be Transported(km): "); mesafe.productDistance = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\n Choose Product Type To Be Transported: ");
            Console.WriteLine("1 - Solid \n2 - Liquid \n3 - Gas \n4 - Valuables");
            Console.Write("\nChoice: "); urunSecim = Convert.ToInt32(Console.ReadLine());

            switch (urunSecim)
            {

                case 1: // Calculation of solids to be transported

                    Solid solidProduct = new Solid();

                    solidProduct.productFactor = 1;

                    Console.Write("\nSolid product name: "); solidProduct.productName = Console.ReadLine();
                    Console.Write("Solid product tonnage(kg): "); solidProduct.solidTonnage = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Solid product packet volume(m3): "); solidProduct.solidVolume = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("*********************************************************************************");
                    Console.WriteLine("\n\nTotal Amount: {0} $", ((solidProduct.solidTonnage * solidProduct.productFactor * mesafe.productDistance) + 100));
                    Console.Read();

                    break;

                case 2: // Calculation of liquids to be transported

                    Liquid liquidProduct = new Liquid();

                    liquidProduct.productFactor = 1.25;

                    Console.Write("\nLiquid product name: "); liquidProduct.productName = Console.ReadLine();
                    Console.Write("Liquid product tonnage(kg): "); liquidProduct.liquidTonnage = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Liquid product specific weight(N/m3): "); liquidProduct.specificWeight = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("*********************************************************************************");
                    Console.WriteLine("\n\nTotal Amount: {0} $", (liquidProduct.specificWeight * liquidProduct.productFactor * mesafe.productDistance));
                    Console.Read();

                    break;

                case 3: // Calculation of gases to be transported

                    Gas gasProducts = new Gas();

                    gasProducts.productFactor = 1.1;

                    Console.Write("\nGas product name: "); gasProducts.productName = Console.ReadLine();
                    Console.Write("Gas product volume(m3): "); gasProducts.gasVolume = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Gas type: "); gasProducts.gasType = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("*********************************************************************************");
                    Console.WriteLine("\n\nTotal Amount: {0} $", ((gasProducts.gasVolume * gasProducts.productFactor * mesafe.productDistance) + 100));
                    Console.Read();

                    break;

                case 4: // Calculation of valuables to be transported

                    Valuables valuables = new Valuables();

                    valuables.productFactor = 1.5;

                    Console.Write("\nValuables name: "); valuables.productName = Console.ReadLine();
                    Console.Write("Valuables volume(m3): "); valuables.valuablesVolume = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Valuables tonnage(kg): "); valuables.valuablesTonnage = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Valuables quantity: "); valuables.valuablesQuantity = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Valuables volume per quantity: "); valuables.valuablesQuantityWeight = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("*********************************************************************************");

                    if (valuables.valuablesTonnage / valuables.valuablesVolume >= 0.5) // Products that meet and dont meet the 0.5 condition are priced differently.
                        Console.WriteLine("\n\nTotal Amount: {0} $", ((valuables.valuablesTonnage * valuables.productFactor) + ((valuables.valuablesVolume * valuables.productFactor)) / 2 + (mesafe.productDistance * 1.5)));
                    else
                        Console.WriteLine("\n\nTotal Amount: {0} $", ((valuables.valuablesVolume * valuables.productFactor) + (mesafe.productDistance * 2)));

                    break;

                default:

                    Console.WriteLine("Wrong Selection Made!\a");

                    break;

            }
        }
    }
}
