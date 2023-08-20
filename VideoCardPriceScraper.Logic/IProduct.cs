namespace VideoCardPriceScraper.Logic;

public interface IProduct
{
    string Name { get; }
    string Description { get; }
    string Type { get; }
}