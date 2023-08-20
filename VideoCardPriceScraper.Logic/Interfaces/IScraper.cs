namespace WebScraper.Logic.Interfaces;

public interface IScraper
{
    IWebsite Website { get; }

    public List<IProduct> Scrape(string category);
}
