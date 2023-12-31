﻿using System;
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

    public URLIdentifier(string siteName, string productCategory) {
        _siteName = siteName; /*pass site name*/
        _baseUrl = IdentifyBaseUrlBySiteName(siteName /*pass site name*/);
        _categoryUrl = IdentifyCategoryUrl(productCategory /*pass category*/);
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

    //This component must figure out what is the structure of a main page that is being scraped to find out category to get the link out of it.
    //Meanwhile strings are hardcoded.
    private string IdentifyCategoryUrl(string category) => new NotImplementedException().Message;

}
