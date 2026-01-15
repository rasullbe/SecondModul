using _5dars.Models;
namespace _5dars.Services
{
    public class CountryService : ICountryService
    {
        List<Country> countries;
        public CountryService()
        {
            countries = new List<Country>();
        }

        public Guid AddCountry(Country country)
        {
            country.CountryId = Guid.NewGuid();
            countries.Add(country);
            return country.CountryId;
        }
        public bool DeleteCountry(Guid countryId)
        {
            foreach (var country in countries)
            {
                if (country.CountryId == countryId)
                {
                    countries.Remove(country);
                    return true;
                }
            }
            return false;
        }

        public List<Country> GetAllCountries()
        {
            return countries;
        }

        public Country? GetCountry(Guid countryId) 
        {
            foreach (var country in countries)
            {
                if (country.CountryId == countryId)
                {
                    return country;
                }
            }
            return null;
        }

        public Country? GetCountryById(Guid countryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCountry(Country country)
        {
            foreach (var existingCountry in countries)
            {
                if (existingCountry.CountryId == country.CountryId)
                {
                    existingCountry.Name = country.Name;
                    existingCountry.Capital = country.Capital;
                    existingCountry.Population = country.Population;
                    return true;
                }
            }
            return false;
        }
    }
}