using WebScraper.Logic.Interfaces;

namespace WebScraper.Logic.Util;

public class Scraper : IScraper
{

    public Scraper(IWebsite website)
    {
        Website = website;
    }

    public IWebsite Website { get; set; }

    public List<IProduct> Scrape(string category)
    {
        throw new NotImplementedException();
    }
}
