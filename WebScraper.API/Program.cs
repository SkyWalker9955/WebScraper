using WebScraper.API;
using WebScraper.Logic.Interfaces;
using WebScraper.Logic.Util;
using static System.Console;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

async Task HandleScrapingAsync(HttpContext context)
{

    var parameters = new ScrapingParameters
    {
        SiteName = context.Request.Query["siteName"],
        ProductCategory = context.Request.Query["productCategory"]
    };

    try
    {
        WriteLine("Identifying URL.");
        URLIdentifier urlIdentifier = new(parameters.SiteName, parameters.ProductCategory);
        //Website website = new(parameters.SiteName, urlIdentifier._baseUrl, urlIdentifier._categoryUrl);

        //Temp code--
        Website website = new(parameters.SiteName, "https://www.newegg.com/", "https://www.newegg.com/Everyday-Saving-Trending-Deals/EventSaleStore/ID-9447?N=100006662&cm_sp=Tab_Components-_-Flyout-_-Deals-by-Categroy-_-Video-Cards-Video-Devices");
        //-----------

        WriteLine("Assigning the website entity to a scraper.");
        Scraper scraper = new(website);

        WriteLine("Scraping...");
        // Have to see what this really returns
        List<IProduct> results = scraper.Scrape();

        WriteLine("Results ready. Returning...");
        // Return the scraped data as JSON response.
        await context.Response.WriteAsJsonAsync(results);
    }
    catch (Exception)
    {
        // Return a bad request status code (400) if an exception happened.
        context.Response.StatusCode = StatusCodes.Status400BadRequest;
    }
}

app.MapGet("/scrape", HandleScrapingAsync);

app.Run();