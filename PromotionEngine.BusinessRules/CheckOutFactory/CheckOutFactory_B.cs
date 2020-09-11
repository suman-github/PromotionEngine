using PromotionEngine.BusinessRules.PromotionProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.CheckOutFactory
{
    public class CheckOutFactory_B : ICheckOutCartFactory
    {
        private string _skuType;
        private int _noOfUnit;

        public CheckOutFactory_B(string skuType, int noOfUnit)
        {
            _skuType = skuType;
            _noOfUnit = noOfUnit;
        }

        public PromotionSKU GetPromotionSKU()
        {
            return new PromotionSKU_B(_skuType, _noOfUnit);
        }
    }
}
