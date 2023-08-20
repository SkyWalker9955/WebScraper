using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper.Logic.Util;

public class URLIdentifier
{
    public string _siteName { get; set; }
    public string _baseUrl { get; set; }
    public string _categoryUrl { get; set; }

    public URLIdentifier(Tuple<string, string> userInput) {
        _siteName = userInput.Item1; /*pass site name*/
        _baseUrl = IdentifyBaseUrlBySiteName(userInput.Item1 /*pass site name*/);
        _categoryUrl = IdentifyCategoryUrl(userInput.Item2 /*pass category*/);
    }

    private string IdentifyBaseUrlBySiteName(string siteName)
    {
        string baseUrl = String.Empty;

        switch (siteName)
        {
            case ("Amazon"): 
                baseUrl = "https://amazon.com";
                break;
            case ("NewEgg"):
                baseUrl = "https://www.newegg.com/";
                break;
            case ("BestBuy"):
                baseUrl = "https://www.bestbuy.com/";
                break;
            case ("MicroCenter"):
                baseUrl = "https://www.microcenter.com/";
                break;
        }
        return baseUrl;
    }

    private string IdentifyCategoryUrl(string category) => new NotImplementedException().Message;
}
