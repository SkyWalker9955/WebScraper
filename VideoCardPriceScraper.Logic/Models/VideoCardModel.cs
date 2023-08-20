namespace WebScraper.Logic.Models;

internal class VideoCardModel : IProduct
{
    private string _type;

    public required string Name { get; set; }
    public required string Price { get; set; }
    public required string DateReleased { get; set; }

    public required string Description { get; set; }

    public required string Type
    {
        get
        {
            return _type;
        }
        set => _type = value;
    }
}
