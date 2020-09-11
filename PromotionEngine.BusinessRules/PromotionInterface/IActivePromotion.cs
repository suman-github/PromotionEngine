using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.BusinessRules.Interface
{
    public interface IActivePromotion
    {
        int GetActivePromotionPrice(int noOfUnit);
    }
}
