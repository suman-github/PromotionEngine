using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.BusinessRules.PromotionProduct;
using PromotionEngine.BusinessRules.CheckOutFactory;

namespace PromotionEngine.Main
{
    public static class CalculateCartTotalPrice
    {
        public static void Run()
        {
            Console.WriteLine("Enter the total number of SKU id's in the cart :");
            int count = int.Parse(Console.ReadLine());
            List<string> carts = new List<string>();
            Console.WriteLine("Enter the SKU id's for cart :");
            for (int i = 1; i <= count; i++)
            {
                carts.Add(Console.ReadLine());
            }
            int totalPrice = CalculateTotalPrice(carts);

            Console.Write("Total Price: "+ totalPrice);
            Console.ReadLine();
        }

        public static int CalculateTotalPrice(List<string> carts)
        {
            ICheckOutCartFactory factory = null;
            bool combinePromotionAvailableWithD = false;
            bool combinePromotionAvailableWithC = false;
            int TotalPrice = 0;
            if (carts == null || carts.Count == 0)
                return 0;
            Dictionary<string, int> disc = new Dictionary<string, int>();
            for (int i = 0; i < carts.Count(); i++)
            {
                if (disc.ContainsKey(carts[i].ToUpper()))
                {
                    disc[carts[i].ToUpper()] += 1;
                }
                else
                    disc.Add(carts[i].ToUpper(), 1);
            }

            if (disc.ContainsKey("C") && disc.ContainsKey("D"))
            {
                if (disc["C"] > disc["D"])
                {
                    disc["C"] = disc["C"] - disc["D"];
                    combinePromotionAvailableWithD = true;
                }
                else if (disc["C"] < disc["D"])
                {
                    disc["D"] = disc["D"] - disc["C"];
                    combinePromotionAvailableWithC = true;
                }
                else
                {
                    disc.Remove("D");
                    combinePromotionAvailableWithC = true;
                }
            }
            foreach (var index in disc)
            {
                var item = index;
                string skuType = item.Key;
                int noOfUnit= item.Value;
                switch (skuType)
                {
                    case "A":
                        factory = new CheckOutFactory_A(skuType, noOfUnit);
                        break;
                    case "B":
                        factory = new CheckOutFactory_B(skuType, noOfUnit);
                        break;
                    case "C":
                        factory = new CheckOutFactory_C(skuType, noOfUnit, combinePromotionAvailableWithC);
                        break;
                    case "D":
                        factory = new CheckOutFactory_D(skuType, noOfUnit, combinePromotionAvailableWithD);
                        break;
                    default:
                        break;
                }

                PromotionSKU objPromotionSku = factory.GetPromotionSKU();
                TotalPrice += objPromotionSku.CalculatePrice();
            }
            return TotalPrice;
        }
    }
}
