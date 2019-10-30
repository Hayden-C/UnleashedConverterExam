using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnleashedConverter
{
    public class CurrencyConverter
    {
        /// <summary>
        /// Take a decimal value representing currency and convert it to a english word representation in dollars and cents
        /// </summary>
        public static string HumanizeCurrency(decimal value)
        {
            var sb = new StringBuilder();
            sb.Append(AddDollarAmount());
            sb.Append(AddCentAmount());

            // Get the dollar amount.
            string AddDollarAmount()
            {
                return "dollar".ToQuantity((long)value, ShowQuantityAs.Words)
                    .Replace('-', ' '); //Remove Hyphens from compound numbers
            }
            // Get the cent amount.
            string AddCentAmount()
            {
                var centsValue = (int)((value - (long)value) * 100);
                if (centsValue == 0)
                    return "";
                string ret = " and "; //There is a dollar amount preceeding this, append " and " to response
                ret += "cent".ToQuantity(centsValue, ShowQuantityAs.Words)
                        .Replace('-', ' '); //Remove Hyphens from compound numbers
                return ret;
            }
            return sb.ToString();
        }
    }
}
