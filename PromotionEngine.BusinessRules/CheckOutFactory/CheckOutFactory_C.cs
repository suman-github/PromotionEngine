using PromotionEngine.BusinessRules.PromotionProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.CheckOutFactory
{
    public class CheckOutFactory_C : ICheckOutCartFactory
    {
        private string _skuType;
        private int _noOfUnit;
        private bool _combinePromotionAvailableWithC;

        public CheckOutFactory_C(string skuType, int noOfUnit, bool combinePromotionAvailableWithC)
        {
            _skuType = skuType;
            _noOfUnit = noOfUnit;
            _combinePromotionAvailableWithC = combinePromotionAvailableWithC;
        }


        public PromotionSKU GetPromotionSKU()
        {
            return new PromotionSKU_C(_skuType, _noOfUnit, _combinePromotionAvailableWithC);
        }
    }

}
