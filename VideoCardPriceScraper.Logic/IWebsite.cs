namespace VideoCardPriceScraper.Logic;

public interface IWebsite
{
    string Name { get; }
    string BaseUrl { get; }
    string CategoryUrl { get; }
}
