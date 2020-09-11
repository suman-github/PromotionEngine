using PromotionEngine.BusinessRules.PromotionProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.CheckOutFactory
{
    public interface ICheckOutCartFactory
    {
        PromotionSKU GetPromotionSKU();
    }
}
