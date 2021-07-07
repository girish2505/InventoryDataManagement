using System;
using System.Collections.Generic;
using System.Text;

namespace InvertoryDataManagement
{
    interface InvertoryInterface
    {
        public void DisplayProducts(List<InventoryUtility.Rice> rice);
        public void DisplayProducts(List<InventoryUtility.Pulse> pulses);
        public void DisplayProducts(List<InventoryUtility.Wheat> Wheat);
        public int CalculatePrice(int weight, int price);
    }
}
