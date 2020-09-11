using PromotionEngine.BusinessRules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.PromotionProduct
{
    public class PromotionSKU_B : PromotionSKU, IActivePromotion
    {
        private readonly string _skuType;
        private readonly int _noOfUnit;
        private readonly int _skuPrice;

        public PromotionSKU_B(string skuType, int noOfUnit)
        {
            _skuType = skuType;
            _noOfUnit = noOfUnit;
            _skuPrice = 30;
        }

        public override string SKUType
        {
            get { return _skuType; }
        }
        public override int SKUUnit
        {
            get { return _noOfUnit; }
        }

        public override int SKUPrice
        {
            get { return _skuPrice; }
        }
        public override int CalculatePrice()
        {
            if (_noOfUnit == 0)
                return 0;
            int TotalPrice = 0;
            int noOfPromotionApplied = _noOfUnit / 2;
            if (noOfPromotionApplied == 0)
                TotalPrice = _noOfUnit * _skuPrice;
            else
            {
                int totalPromotionPrice = GetActivePromotionPrice(noOfPromotionApplied);
                TotalPrice = totalPromotionPrice + (_noOfUnit % 2) * _skuPrice;
            }
            return TotalPrice;

        }
        public int GetActivePromotionPrice(int noOfPromotionApplied)
        {
            return (noOfPromotionApplied != 0) ? 45 * noOfPromotionApplied : 0;
        }
    }
}
