
using System.Collections.Generic;
using WebScraper.Logic.Interfaces;
using WebScraper.Logic.Util;

//NEW BRANCH

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

async Task<List<IProduct>> getScrapedData(string sitrName, string category)
{
    var userInput = Tuple.Create(sitrName, category);

    URLIdentifier urlIdentifier = new(userInput);
    //Website website = new(userInput.Item1, urlIdentifier._baseUrl, urlIdentifier._categoryUrl);

    //Temp code--
    Website website = new(userInput.Item1, "https://www.newegg.com/", "https://www.newegg.com/Everyday-Saving-Trending-Deals/EventSaleStore/ID-9447?N=100006662&cm_sp=Tab_Components-_-Flyout-_-Deals-by-Categroy-_-Video-Cards-Video-Devices");
    //-----------

    Scraper scraper = new(website);

    //Have to see what this really return
    List<IProduct> results = await Task.FromResult(scraper.Scrape());

    return  results;
}

app.MapGet("/scrape", getScrapedData);

app.Run();