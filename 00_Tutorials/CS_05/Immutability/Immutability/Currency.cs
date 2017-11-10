using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    // Below is the currency class  where the property variables are made readonly. 
    // Readonly variables can be only initialized in the constructor and later they cannot be modified.
    class Currency
    {
        private readonly string _CurrencyName;

        public string CurrencyName
        {
            get { return _CurrencyName; }
        }
        private readonly string _CountryName;

        public string CountryName
        {
            get { return _CountryName; }
        }
        public Currency(string paramCurrencyName,
                        string paramCountryName)
        {
            _CurrencyName = paramCurrencyName;
            _CountryName = paramCountryName;
        }
    }
}
