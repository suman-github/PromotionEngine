using PromotionEngine.BusinessRules.PromotionProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.CheckOutFactory
{
    public class CheckOutFactory_A : ICheckOutCartFactory
    {
        private string _skuType;
        private int _noOfUnit;

        public CheckOutFactory_A(string skuType, int noOfUnit)
        {
            _skuType = skuType;
            _noOfUnit = noOfUnit;
        }

        public PromotionSKU GetPromotionSKU()
        {
            return new PromotionSKU_A(_skuType, _noOfUnit);
        }
    }
}
