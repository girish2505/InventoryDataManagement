using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace InvertoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************Welcome to Inventory Data Managemrnt problem************************\n");
            InventoryManager im = new InventoryManager();

            string jsonFilePath = @"C:\Users\giris\source\repos\InvertoryDataManagement\InvertoryDataManagement\json.json";

            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(jsonFilePath));


            Console.WriteLine("1.Rice \n2.Pulse\n3.Wheat\n4.Exit\n");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    im.DisplayProducts(utility.riceList);
                    break;
                case 2:
                    im.DisplayProducts(utility.pulseList);
                    break;
                case 3:
                    im.DisplayProducts(utility.wheatList);
                    break;
                case 4:
                    Console.WriteLine("Exited");
                    break;
            }

        }
    }
}
