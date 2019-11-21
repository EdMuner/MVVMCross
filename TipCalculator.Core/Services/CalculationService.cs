using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal TipAmount(decimal subtotal, double generosity)
        {
            return subtotal * (Decimal)(generosity / 100);
        }
    }
}
