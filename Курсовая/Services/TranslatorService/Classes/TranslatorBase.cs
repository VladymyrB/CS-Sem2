using CalculatorProject.Services.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CalculatorProject.Services
{
    public abstract class TranslatorBase
    {
        public async static Task<string> Translate(string text, Languages languageFrom, Languages languageTo)
        {
            var languageFromCode = getLanguageCode(languageFrom);
            var languageToCode = getLanguageCode(languageTo);
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={languageFromCode}&tl={languageToCode}&dt=t&q={HttpUtility.UrlEncode(text)}";
            var webClient = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            try
            {
                var result = await webClient.DownloadStringTaskAsync(url);

                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "None";
            }
        }

        private static string getLanguageCode(Languages language)
        {
            string languageCode = string.Empty;
            switch (language)
            {
                case Languages.English:
                    languageCode = "en";
                    break;
                case Languages.Russian:
                    languageCode = "ru";
                    break;
                case Languages.Ukrainian:
                    languageCode = "ua";
                    break;
                default:
                    break;
            }
            return languageCode;
        }
    }
}
