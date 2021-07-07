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
        //Display the items in inventory
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
        //ADD items in inventory
        public List<InventoryUtility.Rice> AddToInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter Name of Rice");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter Weight of Rice");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Rice");
            utility.price = Convert.ToInt32(Console.ReadLine());
            riceList.Add(utility);
            Console.WriteLine($"Added {utility.name} of weight {utility.weight} , Price {utility.price} to the Inventory");
            return riceList;
        }
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulseList)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter Name of Pulse");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter Weight of Pulse");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Pulse");
            utility.price = Convert.ToInt32(Console.ReadLine());
            pulseList.Add(utility);
            Console.WriteLine($"Added {utility.name} of weight {utility.weight} , Price {utility.price} to the Inventory");
            return pulseList;
        }
        public List<InventoryUtility.Wheat> AddToInventory(List<InventoryUtility.Wheat> wheatList)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter Name of Wheat");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter Weight of Wheat");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Wheat");
            utility.price = Convert.ToInt32(Console.ReadLine());
            wheatList.Add(utility);
            Console.WriteLine($"Added {utility.name} of weight {utility.weight} , Price {utility.price} to the Inventory");
            return wheatList;
        }
        //Delete items from inventory
        public List<InventoryUtility.Rice> DeleteFromInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter Name of the rice you want to Delete:");
            string nameOfRice = Console.ReadLine().ToLower();
            riceList.Remove(riceList.Find(item => item.name.ToLower().Equals(nameOfRice)));
            Console.WriteLine($"Deleted {nameOfRice} From the Inventory");
            return riceList;
        }
        public List<InventoryUtility.Pulse> DeleteFromInventory(List<InventoryUtility.Pulse> pulseList)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter Name of the Pulse you want to Delete:");
            string nameOfPulse = Console.ReadLine().ToLower();
            pulseList.Remove(pulseList.Find(item => item.name.ToLower().Equals(nameOfPulse)));
            Console.WriteLine($"Deleted {nameOfPulse} From the Inventory");
            return pulseList;
        }
        public List<InventoryUtility.Wheat> DeleteFromInventory(List<InventoryUtility.Wheat> wheatList)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter Name of the Wheat you want to Delete:");
            string nameOfWheat = Console.ReadLine().ToLower();
            wheatList.Remove(wheatList.Find(item => item.name.ToLower().Equals(nameOfWheat)));
            Console.WriteLine($"Deleted {nameOfWheat} From the Inventory");
            return wheatList;
        }
        //edit details inventory
        public List<InventoryUtility.Rice> EditInventory(List<InventoryUtility.Rice> riceList)
        {
            List<InventoryUtility.Rice> rList = DeleteFromInventory(riceList);
            return AddToInventory(rList);
        }
        public List<InventoryUtility.Pulse> EditInventory(List<InventoryUtility.Pulse> pulseList)
        {
            List<InventoryUtility.Pulse> pList = DeleteFromInventory(pulseList);
            return AddToInventory(pList);
        }
        public List<InventoryUtility.Wheat> EditInventory(List<InventoryUtility.Wheat> wheatList)
        {
            List<InventoryUtility.Wheat> wList = DeleteFromInventory(wheatList);
            return AddToInventory(wList);
        }

    }
}
