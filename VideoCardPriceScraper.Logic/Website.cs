namespace VideoCardPriceScraper.Logic;

public class Website : IWebsite
{
    public required string Name { get; set; }

    public required string BaseUrl { get; set; }

    public required string CategoryUrl { get; set; }
}