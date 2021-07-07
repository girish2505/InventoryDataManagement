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
            Console.WriteLine("Welcome to Inventory Data Managemrnt problem");
            InventoryManager im = new InventoryManager();

            string jsonFilePath = @"C:\Users\giris\source\repos\InvertoryDataManagement\InvertoryDataManagement\json.json";

            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(jsonFilePath));
            Console.WriteLine("1.Display Inventories \n2.Add Inventories\n3.Edit Inventories\n4.Delete Inventories\n5.Exit");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
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
                    break;
                case 2:
                    Console.WriteLine("Enter what you need to Add\n");
                    Console.WriteLine("1.Rice \n2.Pulse\n3.Wheat\n4.Exit\n");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            im.AddToInventory(utility.riceList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));

                            break;
                        case 2:
                            im.AddToInventory(utility.pulseList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            im.AddToInventory(utility.wheatList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter what you need to Edit");
                    Console.WriteLine("1.Rice \n2.Pulse\n3.Wheat\n4.Exit\n");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            im.EditInventory(utility.riceList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            im.EditInventory(utility.pulseList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            im.EditInventory(utility.wheatList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter what you need to Delete");
                    Console.WriteLine("1.Rice \n2.Pulse\n3.Wheat\n4.Exit\n");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            im.DeleteFromInventory(utility.riceList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            im.DeleteFromInventory(utility.pulseList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            im.DeleteFromInventory(utility.wheatList);
                            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(utility));
                            break;
                        case 4:
                            Console.WriteLine("Exited");
                            break;
                    }

                    break;
                case 5:
                    Console.WriteLine("Exited");
                    break;
            }

        }
    }
}
