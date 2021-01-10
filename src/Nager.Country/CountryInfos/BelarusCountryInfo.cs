using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Belarus
    /// </summary>
    public class BelarusCountryInfo : ICountryInfo
    {
        public string CommonName => "Belarus";
        public string OfficialName => "Republic of Belarus";
        public Alpha2Code Alpha2Code => Alpha2Code.BY;
        public Alpha3Code Alpha3Code => Alpha3Code.BLR;
        public int NumericCode => 112;
        public string[] TLD => new [] { ".by" };

        public Region Region => Region.Europe;
        public SubRegion SubRegion => SubRegion.EasternEurope;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.LV,
            Alpha2Code.LT,
            Alpha2Code.PL,
            Alpha2Code.RU,
            Alpha2Code.UA,
        };

        public ICurrency[] Currencies => new [] { new BynCurrency() };
        public string[] CallingCodes => new [] { "375" };
    }
}