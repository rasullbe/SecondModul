using _5dars.Models;
namespace _5dars.Services;

public interface ICountryService
{
    public Guid AddCountry(Country country);
    public bool UpdateCountry(Country country);
    public bool DeleteCountry(Guid countryId);
    public Country? GetCountryById(Guid countryId);
    public List<Country> GetAllCountries();
}