using WebScraper.Logic.Interfaces;

namespace WebScraper.Logic.Util;

public class Website : IWebsite
{
    public string Name { get; set; }

    public string BaseUrl { get; set; }

    public string CategoryUrl { get; set; }

    public Website(string name, string baseUrl, string categoryUrl)
    {
        Name = name;
        BaseUrl = baseUrl;
        CategoryUrl = categoryUrl;
    }
}