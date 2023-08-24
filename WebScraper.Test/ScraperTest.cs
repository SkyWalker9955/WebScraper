using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Diagnostics;
using WebScraper.Logic.Interfaces;
using WebScraper.Logic.Util;
using Xunit.Abstractions;

namespace WebScraper.Test;

public class ScraperTest
{
    [Fact]
    public void ScraperReturnsDummyData()
    {
        Website website = new("New Egg", "https://www.newegg.com/", "https://www.newegg.com/Everyday-Saving-Trending-Deals/EventSaleStore/ID-9447?N=100006662&cm_sp=Tab_Components-_-Flyout-_-Deals-by-Categroy-_-Video-Cards-Video-Devices");
        Scraper scraper = new(website);

        List<IProduct> result = scraper.Scrape();

        foreach (IProduct product in result)
        {
            Debug.WriteLine($"{product.Name}");
            Debug.WriteLine($"{product.Description}");
        }

        Assert.NotEmpty(result);
    }
}
