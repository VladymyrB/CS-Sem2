using CalculatorProject.Context;
using CalculatorProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CalculatorProject.InitCountryData
{
    public class InitializationCountryData
    {
        private static string _sourceCoutriesLink = "https://gist.githubusercontent.com/keeguon/2310008/raw/bdc2ce1c1e3f28f9cab5b4393c7549f38361be4e/countries.json";

        public async static Task InitializateData(CalculatorDbContext _dbContext)
        {
            if (!_dbContext.Countries.Any())
            {
                await _dbContext.Countries.AddRangeAsync(getCountries());
                await _dbContext.SaveChangesAsync();
            }
        }

        private static HttpWebRequest createWebRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "GET";

            return request;
        }

        private static List<Country> getCountries()
        {
            List<Country> countries = new List<Country>();
            var requestForCountries = createWebRequest(_sourceCoutriesLink);
            var httpResponseForCountries = (HttpWebResponse)requestForCountries.GetResponse();
            using (var streamReader = new StreamReader(httpResponseForCountries.GetResponseStream()))
            {
                var response = streamReader.ReadToEnd();
                countries = JsonConvert.DeserializeObject<List<Country>>(response);
            }

            return countries;
        }
    }
}
