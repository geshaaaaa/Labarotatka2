using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Laboratorka2
{
  class Converter
    {


        public static double Convert (double amountvalue, Currency currency)
        {

            double returnAmount = 0;
            double eur = 36.90; double usd = 36.65; double rub = 0.6;
            if (currency == Currency.USD)
            {
                returnAmount = amountvalue * usd;
            }
            if (currency == Currency.UAH)
            {
                returnAmount = amountvalue / usd;
            }
             if (currency == Currency.RUB)
            {
                returnAmount = amountvalue * rub;
            }
            if (currency == Currency.EUR)
            {
                returnAmount = amountvalue * eur;
            }  
                return returnAmount;
            
        }


       public enum Currency : int
        {
            USD = 1,
            EUR = 2,
            RUB = 3,
            UAH = 4
        }


    }



}
