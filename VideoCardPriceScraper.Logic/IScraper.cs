namespace WebScraper.Logic;

public interface IScraper
{
    IWebsite Website { get; }
    string CategoryToScrape { get; }

    public List<IProduct> Scrape(string category);
}
