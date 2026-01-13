using _3dars.Models;

namespace _3dars;

internal class Program
{
    static List<Country> Countries = new List<Country>();
    static void Main(string[] args)
    {
        SeedData();
    }

    static void SeedData()
    {
        Countries.Add(new Country
        {
            Name = "USA",
            leaderName = "Trump",
            Capital = "Washington D.C.",
            Population = 331000000,
            Language = "English"
        });
        Countries.Add(new Country
        {
            Name = "Canada",
            leaderName = "Justin Trudeau",
            Capital = "Ottawa",
            Population = 38000000,
            Language = "English, French"
        });
        Countries.Add(new Country
        {
            Name = "Mexico",
            leaderName = "Andrés Manuel López Obrador",
            Capital = "Mexico City",
            Population = 128000000,
            Language = "Spanish"
        });
    }
}
