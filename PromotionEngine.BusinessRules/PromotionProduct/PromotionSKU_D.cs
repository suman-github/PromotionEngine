using PromotionEngine.BusinessRules.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.PromotionProduct
{
    public class PromotionSKU_D : PromotionSKU, IActivePromotion
    {
        private readonly string _skuType;
        private int _noOfUnit;
        private int _skuPrice;
        private bool _combinePromotionAvailableWithD;

        public PromotionSKU_D(string skuType, int noOfUnit, bool combinePromotionAvailableWithD)
        {
            _skuType = skuType;
            _noOfUnit = noOfUnit;
            _combinePromotionAvailableWithD = combinePromotionAvailableWithD;
            _skuPrice = 15;
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
            int noOfPromotionApplied = _noOfUnit;
            if (_combinePromotionAvailableWithD)
            {
                TotalPrice = GetActivePromotionPrice(noOfPromotionApplied);
            }
            else
            {
                TotalPrice = _noOfUnit * _skuPrice;
            }
            return TotalPrice;

        }
        public int GetActivePromotionPrice(int noOfPromotionApplied)
        {
            return (noOfPromotionApplied != 0) ? 30 * noOfPromotionApplied : 0;
        }
    }
}
