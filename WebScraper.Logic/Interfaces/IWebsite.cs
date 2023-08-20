namespace WebScraper.Logic.Interfaces;

public interface IWebsite
{
    string Name { get; }
    string BaseUrl { get; }
    string CategoryUrl { get; }
}
