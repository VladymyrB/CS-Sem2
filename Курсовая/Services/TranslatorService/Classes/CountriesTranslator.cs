using CalculatorProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorProject.Services.TranslatorService.Classes
{
    public class CountriesTranslator: TranslatorBase
    {
        public static IEnumerable<Country> GetTranslatedCountries(List<Country> countries)
        {
            countries.ForEach(i =>
            {
                i.Name = Translate(i.Name, Enums.Languages.English, Enums.Languages.Russian).Result;
            });

            return countries;
        }
    }
}
