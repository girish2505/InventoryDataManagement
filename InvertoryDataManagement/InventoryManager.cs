using System;
using System.Collections.Generic;
using System.Text;

namespace InvertoryDataManagement
{
    class InventoryManager : InvertoryInterface
    {
        public int CalculatePrice(int weight, int price)
        {
            return weight * price;
        }

        public void DisplayProducts(List<InventoryUtility.Rice> rice)
        {
            int totalRicePrice = 0;
            foreach (InventoryUtility.Rice i in rice)
            {
                Console.WriteLine($"\nName={i.name}\nWeight={i.weight} kg\nPrice={i.price}\n");
                totalRicePrice += CalculatePrice(i.weight, i.price);
            }
            Console.WriteLine($"Total Inventory cost for Rice is {totalRicePrice}");
        }

        public void DisplayProducts(List<InventoryUtility.Pulse> Pulse)
        {
            int totalPulsePrice = 0;
            foreach (InventoryUtility.Pulse i in Pulse)
            {
                Console.WriteLine($"\nName={i.name}\nWeight={i.weight} kg\nPrice={i.price}\n");
                totalPulsePrice += CalculatePrice(i.weight, i.price);
            }
            Console.WriteLine($"Total Inventory cost for Pulse is {totalPulsePrice}");
        }
        public void DisplayProducts(List<InventoryUtility.Wheat> Wheat)
        {
            int totalWheatPrice = 0;
            foreach (InventoryUtility.Wheat i in Wheat)
            {
                Console.WriteLine($"\nName={i.name}\nWeight={i.weight} kg\nPrice={i.price}\n");
                totalWheatPrice += CalculatePrice(i.weight, i.price);
            }
            Console.WriteLine($"Total Inventory cost for Wheat is {totalWheatPrice}");
        }
    }
}
