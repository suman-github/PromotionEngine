using PromotionEngine.BusinessRules.PromotionProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.CheckOutFactory
{
    public class CheckOutFactory_D : ICheckOutCartFactory
    {
        private string _skuType;
        private int _noOfUnit;
        private bool _combinePromotionAvailableWithD;

        public CheckOutFactory_D(string skuType, int noOfUnit, bool combinePromotionAvailableWithD)
        {
            _skuType = skuType;
            _noOfUnit = noOfUnit;
            _combinePromotionAvailableWithD = combinePromotionAvailableWithD;
        }

        public PromotionSKU GetPromotionSKU()
        {
            return new PromotionSKU_D(_skuType, _noOfUnit, _combinePromotionAvailableWithD);
        }
    }
}
