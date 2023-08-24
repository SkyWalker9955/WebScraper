
using System.Collections.Generic;
using WebScraper.Logic.Interfaces;
using WebScraper.Logic.Util;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

async Task<List<IProduct>> getScrapedData(string sitrName, string category)
{

    var userInput = Tuple.Create(sitrName, category);

    URLIdentifier urlIdentifier = new(userInput);

    Website website = new(userInput.Item1, urlIdentifier._baseUrl, urlIdentifier._categoryUrl);

    Scraper scraper = new(website);

    //Have to see wht this really return
    List<IProduct> results = await Task.FromResult(scraper.Scrape(category)); //This is wrong. FIX! scraper does not take category. it should know about the category from website

    return  results;
}

app.MapGet("/scrape", getScrapedData);

app.Run();