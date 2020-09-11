using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.PromotionProduct
{
    public abstract class PromotionSKU
    {
        public abstract string SKUType { get; }
        public abstract int SKUUnit { get; }
        public abstract int SKUPrice { get; }
        public abstract int CalculatePrice();
    }
}
